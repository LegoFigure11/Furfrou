using Furfrou.Core.Connection;
using Furfrou.Core.Interfaces;
using Microsoft.VisualBasic;
using PKHeX.Core;
using SysBot.Base;
using System.Globalization;
using System.Text.Json;
using static Furfrou.Core.Connection.Util;
using static System.Buffers.Binary.BinaryPrimitives;

namespace Furfrou.WinForms;

public partial class MainWindow : Form
{
    private static CancellationTokenSource Source = new();
    private static readonly Lock _connectLock = new();

    public ClientConfig Config;
    private ConnectionWrapperAsync ConnectionWrapper = default!;
    private readonly SwitchConnectionConfig ConnectionConfig;

    public readonly GameStrings Strings = GameInfo.GetStrings("en");

    private bool stop;
    private bool reset;
    private bool readPause;
    private bool flipPause;
    private long flipTarget;
    private bool forecast;
    private long total;
    private bool found;
    private ulong remaining;

    private RadarContinuationConfig _cfg = new();

    List<RadarContinuationFrame> Frames = [];

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

        Text = $"Automatic Radar Seed Extrapolator v{v.Major}.{v.Minor}.{v.Build}{build}";

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
                stop = true;
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
                    var bytes = StringToByteArray(bytestring);
                    await ConnectionWrapper.WriteB1S1(bytes, Source.Token).ConfigureAwait(false);
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
                    var bytes = StringToByteArray(bytestring);
                    await ConnectionWrapper.WriteWholeBox(bytes, Source.Token).ConfigureAwait(false);
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

                PK9 pk = new(Data);
                FillFields(pk);
            }
            catch (Exception ex)
            {
                this.DisplayMessageBox(ex.Message);
                return;
            }
        });
    }

    private void FillFields(PK9 pk)
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

                PK9 pk = new(Data);
                FillFields(pk);
            }
            catch (Exception ex)
            {
                this.DisplayMessageBox(ex.Message);
                return;
            }
        });
    }
}
