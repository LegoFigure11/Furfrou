using System.Text.Json;
using Furfrou.Core.Connection;
using PKHeX.Core;
using SysBot.Base;
using static System.Buffers.Binary.BinaryPrimitives;
using static Furfrou.Core.Connection.Util;

namespace Furfrou.WinForms;

public partial class MainWindow : Form
{
    private static CancellationTokenSource Source = new();
    private static readonly Lock _connectLock = new();

    public ClientConfig Config;
    private ConnectionWrapperAsync ConnectionWrapper = default!;
    private readonly SwitchConnectionConfig ConnectionConfig;

    public readonly GameStrings Strings = GameInfo.GetStrings("en");

    private readonly Version CurrentVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version!;

    public MainWindow()
    {
        Config = new ClientConfig();
        var configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
        if (File.Exists(configPath))
        {
            var text = File.ReadAllText(configPath);
            Config = JsonSerializer.Deserialize<ClientConfig>(text)!;
        }
        else
        {
            Config = new();
        }

        ConnectionConfig = new()
        {
            IP = Config.IP,
            Port = Config.Protocol is SwitchProtocol.WiFi ? 6000 : Config.UsbPort,
            Protocol = Config.Protocol,
        };

        var v = CurrentVersion;
#if DEBUG
        var build = "";

        var asm = System.Reflection.Assembly.GetEntryAssembly();
        var gitVersionInformationType = asm?.GetType("GitVersionInformation");
        var sha = gitVersionInformationType?.GetField("ShortSha");

        if (sha is not null) build += $"#{sha.GetValue(null)}";

        var date = File.GetLastWriteTime(AppContext.BaseDirectory);
        build += $" (dev-{date:yyyyMMdd})";

#else
        var build = "";
#endif

        Text = $"Furfrou v{v.Major}.{v.Minor}.{v.Build}{build}";

        InitializeComponent();
    }

    private void MainWindow_Load(object sender, EventArgs e)
    {
        CenterToScreen();

        if (Config.Protocol is SwitchProtocol.WiFi)
        {
            TB_SwitchIP.Text = Config.IP;
        }
        else
        {
            L_SwitchIP.Text = "USB Port:";
            TB_SwitchIP.Text = $"{Config.UsbPort}";
        }

        TB_TID.Text = $"{Config.TID:D5}";
        TB_SID.Text = $"{Config.SID:D5}";

        TB_Status.Text = "Not Connected.";

        // CheckForUpdates();
    }

    private void Connect(CancellationToken token)
    {
        Task.Run(
            async () =>
            {
                SetControlEnabledState(false, B_Connect);
                try
                {
                    ConnectionConfig.IP = TB_SwitchIP.Text;
                    (bool success, string err) = await ConnectionWrapper
                        .Connect(token)
                        .ConfigureAwait(false);
                    if (!success)
                    {
                        SetControlEnabledState(true, B_Connect);
                        this.DisplayMessageBox(err);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    SetControlEnabledState(true, B_Connect);
                    this.DisplayMessageBox(ex.Message);
                    return;
                }

                UpdateStatus("Detecting game version...");

                var (tid, sid) = ConnectionWrapper.GetIDs();
                SetTextBoxText(tid, TB_TID);
                SetTextBoxText(sid, TB_SID);

                SetControlEnabledState(true, B_Disconnect);
            },
            token
        );
    }

    private void Disconnect(CancellationToken token)
    {
        Task.Run(
            async () =>
            {
                SetControlEnabledState(false, B_Disconnect);
                try
                {
                    (bool success, string err) = await ConnectionWrapper.DisconnectAsync(token).ConfigureAwait(false);
                    if (!success) this.DisplayMessageBox(err);
                }
                catch (Exception ex)
                {
                    this.DisplayMessageBox(ex.Message);
                }

                await Source.CancelAsync().ConfigureAwait(false);
                Source = new();
                SetControlEnabledState(true, B_Connect);
            },
            token
        );
    }

    private void UpdateStatus(string status)
    {
        SetTextBoxText(status, TB_Status);
    }

    public void SetTextBoxText(string text, params object[] obj)
    {
        foreach (object o in obj)
        {
            if (o is not TextBox tb)
                continue;

            if (InvokeRequired)
                Invoke(() => tb.Text = text);
            else
                tb.Text = text;
        }
    }

    public void SetControlEnabledState(bool state, params object[] obj)
    {
        foreach (object o in obj)
        {
            if (o is not Control c)
                continue;

            if (InvokeRequired)
                Invoke(() => c.Enabled = state);
            else
                c.Enabled = state;
        }
    }

    public void SetBindingSourceDataSource(object source, params object[] obj)
    {
        foreach (object o in obj)
        {
            if (o is not BindingSource b)
                continue;

            if (InvokeRequired)
                Invoke(() => b.DataSource = source);
            else
                b.DataSource = source;
        }
    }

    public uint GetNUDValue(NumericUpDown c)
    {
        return (uint)(InvokeRequired ? Invoke(() => c.Value) : c.Value);
    }

    public int GetComboBoxSelectedIndex(ComboBox c)
    {
        return (InvokeRequired ? Invoke(() => c.SelectedIndex) : c.SelectedIndex);
    }

    private void B_Connect_Click(object sender, EventArgs e)
    {
        lock (_connectLock)
        {
            if (ConnectionWrapper is { Connected: true })
                return;

            ConnectionWrapper = new(ConnectionConfig, UpdateStatus);
            Connect(Source.Token);
        }
    }

    private void B_Disconnect_Click(object sender, EventArgs e)
    {
        lock (_connectLock)
        {
            if (ConnectionWrapper is not { Connected: true })
                return;

            Disconnect(Source.Token);
        }
    }

    private void SetRAMText(byte[] data)
    {
        var text = string.Join(" ", data.Select(bytes => $"{bytes:X2}"));
        if (InvokeRequired)
            Invoke(() => TB_RAM.Text = text);
        else TB_RAM.Text = text;
    }

    private void B_WritePlayerB1S1_Click(object sender, EventArgs e)
    {
        Task.Run(async () =>
            {
                try
                {
                    var bytestring = TB_RAM.Text.Replace("\t", "").Replace(" ", "").Trim();
                    if (bytestring.Length != 688) throw new Exception($"Data is not the correct length! Aborting write.\n\nExpected: 344\nReceived: {bytestring.Length / 2}");
                    var bytes = StringToByteArray(bytestring);
                    PA9 pk = new(bytes);
                    if (!pk.ChecksumValid) throw new Exception("Data does not contain a valid checksum! Aborting write.");
                    var data = StringToByteArray(bytestring);
                    await ConnectionWrapper.WriteB1S1(data, Source.Token).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    this.DisplayMessageBox(ex.Message);
                    return;
                }
            }
        );
    }

    private void B_WriteEntireBox_Click(object sender, EventArgs e)
    {
        Task.Run(async () =>
            {
                try
                {
                    var bytestring = TB_RAM.Text.Replace("\t", "").Replace(" ", "").Trim();
                    if (bytestring.Length != 688) throw new Exception($"Data is not the correct length! Aborting write.\n\nExpected: 344\nReceived: {bytestring.Length / 2}");
                    var bytes = StringToByteArray(bytestring);
                    PA9 pk = new(bytes);
                    if (!pk.ChecksumValid) throw new Exception("Data does not contain a valid checksum! Aborting write.");
                    var data = StringToByteArray(bytestring);
                    await ConnectionWrapper.WriteWholeBox(data, Source.Token).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    this.DisplayMessageBox(ex.Message);
                    return;
                }
            }
        );
    }

    private void TB_RAM_TextChanged(object sender, EventArgs e)
    {
        var str = TB_RAM.Text.Replace("\t", "").Replace(" ", "").Trim();
        var len = str.Length / 2;
        L_Size.Text = $"Size: 0x{len:X} / {len:0}";
    }

    private void B_ReadPlayerB1S1_Click(object sender, EventArgs e)
    {
        Task.Run(async () =>
        {
            try
            {
                var Data = await ConnectionWrapper.ReadB1S1(Source.Token).ConfigureAwait(false);
                SetRAMText(Data);

                PA9 pk = new(Data);
                FillFields(pk);
            }
            catch (Exception ex)
            {
                this.DisplayMessageBox(ex.Message);
                return;
            }
        });
    }

    private void FillFields(PA9 pk)
    {
        string gender = pk.Gender switch
        {
            0 => "Male",
            1 => "Female",
            _ => "Unknown",
        };

        SetTextBoxText($"{pk.EncryptionConstant:X8}", TB_EC);
        SetTextBoxText($"{pk.PID:X8}", TB_PID);
        SetTextBoxText(Strings.Species[pk.Species], TB_Species);
        SetTextBoxText(pk.OriginalTrainerName, TB_OT);
        SetTextBoxText($"{pk.TID16:D5}", TB_InfoTID);
        SetTextBoxText($"{pk.SID16:D5}", TB_InfoSID);
        SetTextBoxText(Strings.Natures[(int)pk.Nature], TB_Nature);
        SetTextBoxText(gender, TB_Gender);
        SetTextBoxText($"{pk.IV_HP:D2}/{pk.IV_ATK:D2}/{pk.IV_DEF:D2}/{pk.IV_SPA:D2}/{pk.IV_SPD:D2}/{pk.IV_SPE:D2}", TB_IVs);
    }

    private void B_ReadTrade_Click(object sender, EventArgs e)
    {
        Task.Run(async () =>
        {
            try
            {
                await ConnectionWrapper.ResolveTradePointers(Source.Token).ConfigureAwait(false);
                var nid = await ConnectionWrapper.ReadNID(Source.Token).ConfigureAwait(false);
                SetTextBoxText(nid, T_NID);
                var myStatus = await ConnectionWrapper.ReadTradeMyStatus(Source.Token).ConfigureAwait(false);
                var Data = await ConnectionWrapper.ReadTradePokemon(Source.Token).ConfigureAwait(false);

                var tid = ReadUInt16LittleEndian(myStatus.AsSpan());
                var sid = ReadUInt16LittleEndian(myStatus.AsSpan(2));
                var ot = StringConverter8.GetString(myStatus.AsSpan(0x8, 26));

                SetRAMText(Data);

                SetTextBoxText($"{tid:D05}", TB_PartnerTID);
                SetTextBoxText($"{sid:D05}", TB_PartnerSID);

                SetTextBoxText(ot, TB_PartnerOT);

                PA9 pk = new(Data);
                if (pk.ChecksumValid) FillFields(pk);
            }
            catch (Exception ex)
            {
                this.DisplayMessageBox(ex.Message);
                return;
            }
        });
    }

    private void B_Save_Click(object sender, EventArgs e)
    {
        SaveFileDialog Save = new()
        {
            Filter = "Encrypted Pokémon File (*.ea9)|*.ea9|Binary File (*.bin)|*.bin|All Files (*.*)|*.*",
            Title = "Save As...",
        };
        if (Save.ShowDialog() == DialogResult.OK)
        {
            FileStream fs = new(Save.FileName, FileMode.Create);
            BinaryWriter bw = new(fs);

            var bytestring = TB_RAM.Text.Replace("\t", "").Replace(" ", "").Trim();
            var Bytes = StringToByteArray(bytestring);

            bw.Write(Bytes);
            fs.Close();
            bw.Close();
        }
    }

    private void B_Load_Click(object sender, EventArgs e)
    {
        OpenFileDialog Open = new()
        {
            Title = "Select a File",
            Filter = "Encrypted Pokémon File (*.ea9)|*.ea9|Binary File (*.bin)|*.bin|All Files (*.*)|*.*",
            FilterIndex = 1,
            RestoreDirectory = true,
            Multiselect = false
        };
        if (Open.ShowDialog() == DialogResult.OK)
        {
            var file = Open.FileName;
            try
            {
                var bytes = File.ReadAllBytes(file);
                SetRAMText(bytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void B_IV_Min_Click(object sender, EventArgs e)
    {
        var st = ((Button)sender).Name.Replace("B_", string.Empty).Replace("_Min", string.Empty);
        List<string> stats = ModifierKeys == Keys.Shift ? ["HP", "Atk", "Def", "SpA", "SpD", "Spe"] : [st];
        foreach (var stat in stats)
        {
            var min = (NumericUpDown)Controls.Find($"NUD_{stat}_Min", true).FirstOrDefault()!;
            var max = (NumericUpDown)Controls.Find($"NUD_{stat}_Max", true).FirstOrDefault()!;
            min.Value = 0;
            max.Value = 0;
        }
    }

    private void B_IV_Max_Click(object sender, EventArgs e)
    {
        var st = ((Button)sender).Name.Replace("B_", string.Empty).Replace("_Max", string.Empty);
        List<string> stats = ModifierKeys == Keys.Shift ? ["HP", "Atk", "Def", "SpA", "SpD", "Spe"] : [st];
        foreach (var stat in stats)
        {
            var min = (NumericUpDown)Controls.Find($"NUD_{stat}_Min", true).FirstOrDefault()!;
            var max = (NumericUpDown)Controls.Find($"NUD_{stat}_Max", true).FirstOrDefault()!;
            min.Value = 31;
            max.Value = 31;
        }
    }

    private void IV_Label_Click(object sender, EventArgs e)
    {
        var st = ((Label)sender).Name.Replace("L_", string.Empty);
        List<string> stats = ModifierKeys == Keys.Shift ? ["HP", "Atk", "Def", "SpA", "SpD", "Spe"] : [st];
        foreach (var stat in stats)
        {
            var min = (NumericUpDown)Controls.Find($"NUD_{stat}_Min", true).FirstOrDefault()!;
            var max = (NumericUpDown)Controls.Find($"NUD_{stat}_Max", true).FirstOrDefault()!;
            min.Value = 0;
            max.Value = 31;
        }
    }

    private void B_Reset_Click(object sender, EventArgs e)
    {
        Task.Run(async () =>
        {
            try
            {
                bool found = false;
                var res = 0;
                PA9 last = new();
                while (!found && ConnectionWrapper is { Connected: true } && !Source.Token.IsCancellationRequested)
                {
                    UpdateStatus($"Resets: {res++}");
                    PA9? pk;
                    var targetIndex = GetComboBoxSelectedIndex(CB_Target);
                    var target = targetIndex switch
                    {
                        2 => "Zygarde",
                        1 => "Yveltal",
                        _ => "Xerneas"
                    };
                    do
                    {
                        await ConnectionWrapper.DoTurboCommand("Y", Source.Token);
                        await ConnectionWrapper.DoTurboCommand("A", Source.Token);
                        var b = await ConnectionWrapper.ReadWildPokemon(Source.Token);
                        SetRAMText(b);
                        pk = new PA9(b);
                        FillFields(pk);
                    } while (Strings.Species[pk.Species] != target || ComparePkm(pk, last));

                    int[] ivs = [pk.IV_HP, pk.IV_ATK, pk.IV_DEF, pk.IV_SPA, pk.IV_SPD, pk.IV_SPE];
                    uint[] min =
                    [
                        GetNUDValue(NUD_HP_Min), GetNUDValue(NUD_Atk_Min), GetNUDValue(NUD_Def_Min),
                        GetNUDValue(NUD_SpA_Min), GetNUDValue(NUD_SpD_Min), GetNUDValue(NUD_Spe_Min)
                    ];
                    uint[] max =
                    [
                        GetNUDValue(NUD_HP_Max), GetNUDValue(NUD_Atk_Max), GetNUDValue(NUD_Def_Max),
                        GetNUDValue(NUD_SpA_Max), GetNUDValue(NUD_SpD_Max), GetNUDValue(NUD_Spe_Max)
                    ];

                    bool pass = true;
                    for (var i = 0; i < ivs.Length; i++)
                    {
                        if ((ivs[i] >= min[i] && ivs[i] <= max[i]) || ivs[i] == 31) continue;
                        pass = false;
                        break;
                    }

                    if (pass)
                    {
                        var targetNatures = GetControlText(TB_Natures).ToLower();
                        var nature = Strings.Natures[(int)pk.Nature].ToLower();
                        found = targetNatures.Length == 0 || targetNatures.Contains(nature);
                    }

                    if (!pass || !found)
                    {
                        await ConnectionWrapper.CloseGame(Source.Token);
                        await ConnectionWrapper.OpenGame(Source.Token);
                        last = pk;
                    }
                }

                UpdateStatus($"Result found! {res}");
                await ConnectionWrapper.DoTurboCommand("HOME", Source.Token);
                Disconnect(Source.Token);
            }
            catch (Exception ex)
            {
                //this.DisplayMessageBox(ex.Message, "Reset Error");
                B_Reset_Click(sender, e);
            }
        });
    }

    public string GetControlText(Control c)
    {
        return (InvokeRequired ? Invoke(() => c.Text) : c.Text);
    }

    private static bool ComparePkm(PA9 a, PA9 b)
    {
        var _a = a.Data;
        var _b = b.Data;
        for (var i = 0; i < _a.Length; i++)
        {
            if (_a[i] != _b[i]) return false;
        }

        return true;
    }

    private void B_ShinyStash_Click(object sender, EventArgs e)
    {
        Task.Run(async () =>
        {
            try
            {
                var pks = await ConnectionWrapper.ReadShinyStash(Source.Token).ConfigureAwait(false);
                if (pks.Count == 0)
                {
                    MessageBox.Show("No stashed shinies found.");
                }
                else
                {
                    var s = $"Stashed Shinies: {pks.Count}\n\n";

                    foreach (var pk in pks)
                    {
                        var gender = pk.Gender switch
                        {
                            0 => " (M)",
                            1 => " (F)",
                            _ => "",
                        };
                        s +=
                            $"{Strings.Species[pk.Species]}{gender} - {Strings.Natures[(int)pk.Nature]} - {pk.IV_HP:D2}/{pk.IV_ATK:D2}/{pk.IV_DEF:D2}/{pk.IV_SPA:D2}/{pk.IV_SPD:D2}/{pk.IV_SPE:D2}\n";
                    }

                    MessageBox.Show(s);
                }
            }
            catch (Exception ex)
            {
                this.DisplayMessageBox(ex.Message, "Shiny Stash Error");
            }
        });

    }
}
