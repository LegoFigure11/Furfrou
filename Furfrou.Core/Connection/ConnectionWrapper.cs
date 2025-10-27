using System.Diagnostics;
using System.Net.Sockets;
using Furfrou.Core.Structures;
using PKHeX.Core;
using SysBot.Base;
using static System.Buffers.Binary.BinaryPrimitives;
using static SysBot.Base.SwitchButton;
using static SysBot.Base.SwitchCommand;

namespace Furfrou.Core.Connection;

public class ConnectionWrapperAsync(SwitchConnectionConfig Config, Action<string> StatusUpdate) : Offsets
{
    public readonly ISwitchConnectionAsync Connection = Config.Protocol switch
    {
        SwitchProtocol.USB => new SwitchUSBAsync(Config.Port),
        _ => new SwitchSocketAsync(Config),
    };

    public bool Connected => IsConnected;
    private bool IsConnected { get; set; }
    private readonly bool CRLF = Config.Protocol is SwitchProtocol.WiFi;

    private readonly SAV9SV sav = new();

    private ulong PlayerMyStatusOffset;
    private ulong PlayerB1S1Offset;
    private ulong TradePartnerMyStatusOffset;
    private ulong TradePartnerNIDOffset;
    private ulong TradePartnerPokemonOffset;
    private ulong ShinyStashOffset;
    private ulong WildPokemonOffset;

    public async Task<(bool, string)> Connect(CancellationToken token)
    {
        if (Connected) return (true, "");

        try
        {
            StatusUpdate("Connecting...");
            Connection.Connect();
            IsConnected = true;

            StatusUpdate("Detecting Game Version");
            string title = await Connection.GetTitleID(token).ConfigureAwait(false);

            var myStatusPointer = title switch
            {
                LegendsZAID => PlayerMyStatusPointer,
                _           => throw new Exception("Cannot detect Legends: Z-A running on your switch!")
            };

            StatusUpdate("Caching Pointers...");
            PlayerMyStatusOffset = await Connection.PointerAll(myStatusPointer,  token).ConfigureAwait(false);
            PlayerB1S1Offset = await Connection.PointerAll(PlayerB1S1Pointer, token).ConfigureAwait(false);

            StatusUpdate("Reading SAV...");
            var tid = await Connection.ReadBytesAbsoluteAsync(PlayerMyStatusOffset, 2, token).ConfigureAwait(false);
            var sid = await Connection.ReadBytesAbsoluteAsync(PlayerMyStatusOffset + 2, 2, token).ConfigureAwait(false);

            sav.MyStatus.TID16 = ReadUInt16LittleEndian(tid);
            sav.MyStatus.SID16 = ReadUInt16LittleEndian(sid);

            StatusUpdate("Connected!");
            return (true, "");
        }
        catch (SocketException e)
        {
            IsConnected = false;
            return (false, e.Message);
        }
    }

    public async Task<(bool, string)> DisconnectAsync(CancellationToken token)
    {
        if (!Connected) return (true, "");

        try
        {
            StatusUpdate("Disconnecting controller");
            await Connection.SendAsync(DetachController(CRLF), token).ConfigureAwait(false);

            StatusUpdate("Disconnecting...");
            Connection.Disconnect();
            IsConnected = false;
            StatusUpdate("Disconnected!");
            return (true, "");
        }
        catch (SocketException e)
        {
            IsConnected = false;
            return (false, e.Message);
        }
    }

    public async Task ResolveTradePointers(CancellationToken token)
    {
        TradePartnerMyStatusOffset = await Connection.PointerAll(TradePartnerMyStatusPointer, token).ConfigureAwait(false);
        TradePartnerNIDOffset      = await Connection.PointerAll(TradePartnerNIDPointer     , token).ConfigureAwait(false);
        TradePartnerPokemonOffset  = await Connection.PointerAll(TradePartnerPokemonPointer , token).ConfigureAwait(false);
        Debug.Print($"MyStatus: 0x{TradePartnerMyStatusOffset:X16}");
        Debug.Print($"NID:      0x{TradePartnerNIDOffset:X16}");
        Debug.Print($"Pokemon:  0x{TradePartnerPokemonOffset:X16}");
    }

    public async Task DoTurboCommand(string command, CancellationToken token)
    {
        switch (command)
        {
            case "Wait (100ms)":
                await Task.Delay(100, token).ConfigureAwait(false);
                break;
            case "Wait (500ms)":
                await Task.Delay(500, token).ConfigureAwait(false);
                break;
            case "Wait (1000ms)":
                await Task.Delay(1_000, token).ConfigureAwait(false);
                break;
            default:
                _ = command switch
                {
                    "A" => await Connection.SendAsync(Click(A, CRLF), token).ConfigureAwait(false),
                    "B" => await Connection.SendAsync(Click(B, CRLF), token).ConfigureAwait(false),
                    "X" => await Connection.SendAsync(Click(X, CRLF), token).ConfigureAwait(false),
                    "Y" => await Connection.SendAsync(Click(Y, CRLF), token).ConfigureAwait(false),

                    "Left Stick (L3)" => await Connection.SendAsync(Click(LSTICK, CRLF), token).ConfigureAwait(false),
                    "Right Stick (R3)" => await Connection.SendAsync(Click(RSTICK, CRLF), token).ConfigureAwait(false),

                    "L" => await Connection.SendAsync(Click(L, CRLF), token).ConfigureAwait(false),
                    "R" => await Connection.SendAsync(Click(R, CRLF), token).ConfigureAwait(false),
                    "ZL" => await Connection.SendAsync(Click(ZL, CRLF), token).ConfigureAwait(false),
                    "ZR" => await Connection.SendAsync(Click(ZR, CRLF), token).ConfigureAwait(false),

                    "+" => await Connection.SendAsync(Click(PLUS, CRLF), token).ConfigureAwait(false),
                    "-" => await Connection.SendAsync(Click(MINUS, CRLF), token).ConfigureAwait(false),

                    "Up (Hold)" => await Connection.SendAsync(SetStick(SwitchStick.LEFT, 0, 30000, CRLF), token).ConfigureAwait(false),
                    "Down (Hold)" => await Connection.SendAsync(SetStick(SwitchStick.LEFT, 0, -30000, CRLF), token).ConfigureAwait(false),
                    "Left (Hold)" => await Connection.SendAsync(SetStick(SwitchStick.LEFT, -30000, 0, CRLF), token).ConfigureAwait(false),
                    "Right (Hold)" => await Connection.SendAsync(SetStick(SwitchStick.LEFT, 30000, 0, CRLF), token).ConfigureAwait(false),
                    "Release Stick" => await Connection.SendAsync(SwitchCommand.ResetStick(SwitchStick.LEFT, CRLF), token).ConfigureAwait(false),

                    "D-Pad Up" => await Connection.SendAsync(Click(DUP, CRLF), token).ConfigureAwait(false),
                    "D-Pad Down" => await Connection.SendAsync(Click(DDOWN, CRLF), token).ConfigureAwait(false),
                    "D-Pad Left" => await Connection.SendAsync(Click(DLEFT, CRLF), token).ConfigureAwait(false),
                    "D-Pad Right" => await Connection.SendAsync(Click(DRIGHT, CRLF), token).ConfigureAwait(false),

                    "HOME" => await Connection.SendAsync(Click(HOME, CRLF), token).ConfigureAwait(false),
                    "Screenshot" => await Connection.SendAsync(Click(CAPTURE, CRLF), token).ConfigureAwait(false),

                    _ => throw new NotImplementedException(),
                };
                break;
        }
    }

    public (string TID, string SID) GetIDs()
    {
        var myStatus = sav.MyStatus;
        return ($"{myStatus.TID16:D05}", $"{myStatus.SID16:D05}");
    }

    public async Task<byte[]> ReadB1S1(CancellationToken token)
    {
        return await Connection.ReadBytesAbsoluteAsync(PlayerB1S1Offset, (int)PlayerB1S1Size, token).ConfigureAwait(false);
    }

    public async Task<byte[]> ReadWildPokemon(CancellationToken token)
    {
        WildPokemonOffset = await Connection.PointerAll(WildPokemonPointer, token).ConfigureAwait(false);
        return await Connection.ReadBytesAbsoluteAsync(WildPokemonOffset, (int)PlayerB1S1Size, token).ConfigureAwait(false);
    }

    public async Task<byte[]> ReadTradePokemon(CancellationToken token)
    {
        return await Connection.ReadBytesAbsoluteAsync(TradePartnerPokemonOffset, (int)PlayerB1S1Size, token).ConfigureAwait(false);
    }

    public async Task<string> ReadNID(CancellationToken token)
    {
        var b = await Connection.ReadBytesAbsoluteAsync(TradePartnerNIDOffset, 8, token).ConfigureAwait(false);
        return Convert.ToHexString(b);
    }

    public async Task<byte[]> ReadTradeMyStatus(CancellationToken token)
    {
        return await Connection.ReadBytesAbsoluteAsync(TradePartnerMyStatusOffset, 120,  token).ConfigureAwait(false);
    }

    public async Task<List<PA9>> ReadShinyStash(CancellationToken token)
    {
        List<PA9> l = [];
        ShinyStashOffset = await Connection.PointerAll(CachedShinyBlockPointer, token).ConfigureAwait(false);
        for (var i = 0; i < 10; i++)
        {
            var bytes = await Connection.ReadBytesAbsoluteAsync(ShinyStashOffset + (ulong)(i * 0x1f0), 344, token)
                .ConfigureAwait(false);

            var pk = new PA9(bytes);
            if (pk.Species != 0) l.Add(pk);
        }

        return l;
    }

    public async Task WriteB1S1(byte[] data, CancellationToken token)
    {
        await Connection.WriteBytesAbsoluteAsync(data, PlayerB1S1Offset, token).ConfigureAwait(false);
    }

    public async Task WriteWholeBox(byte[] data, CancellationToken token)
    {
        for (var i = 0; i < 30; i++) {
            await Connection.WriteBytesAbsoluteAsync(data, PlayerB1S1Offset + (ulong)(i * PlayerB1S1Size) + (ulong)(i * BoxPadding), token).ConfigureAwait(false);
        }
    }

    public async Task CloseGame(CancellationToken token)
    {
        StatusUpdate("Returning HOME...");
        await Connection.SendAsync(Click(HOME, CRLF), token).ConfigureAwait(false);
        await Task.Delay(3_000, token).ConfigureAwait(false);
        StatusUpdate("Closing game...");
        await Connection.SendAsync(Click(X, CRLF), token).ConfigureAwait(false);
        await Task.Delay(1_000, token).ConfigureAwait(false);
        await Connection.SendAsync(Click(A, CRLF), token).ConfigureAwait(false);
        await Task.Delay(4_000, token).ConfigureAwait(false);
    }

    public async Task OpenGame(CancellationToken token)
    {
        StatusUpdate("Loading profile...");
        await Connection.SendAsync(Click(A, CRLF), token).ConfigureAwait(false);
        await Task.Delay(3_000, token).ConfigureAwait(false);

        /*if (config.AvoidSystemUpdate)
        {
            StatusUpdate("Avoiding System Update...");
            await Connection.SendAsync(Click(DUP, CRLF), token).ConfigureAwait(false);
            await Task.Delay(0_600, token).ConfigureAwait(false);
            await Connection.SendAsync(Click(A, CRLF), token).ConfigureAwait(false);
            await Task.Delay(1_000 + config.ExtraTimeLoadProfile, token).ConfigureAwait(false);
        }*/

        StatusUpdate("Opening the game...");
        await Connection.SendAsync(Click(A, CRLF), token).ConfigureAwait(false);
        await Task.Delay(0_600, token).ConfigureAwait(false);

        StatusUpdate("Loading game...");
        await Task.Delay(10_000, token).ConfigureAwait(false);

        StatusUpdate("Pressing A through Title Screen...");
        await Connection.SendAsync(Click(A, CRLF), token).ConfigureAwait(false);
        await Task.Delay(2_500, token).ConfigureAwait(false);
    }
}
