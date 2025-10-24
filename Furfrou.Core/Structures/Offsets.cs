namespace Furfrou.Core.Structures;

public abstract class Offsets
{
    public const string LegendsZAID                                        = "0100F43008C44000";

    public static IReadOnlyList<long> PlayerMyStatusPointer       { get; } = [0x41F0960, 0x18];
    
    public static IReadOnlyList<long> PlayerB1S1Pointer           { get; } = [0x41F09A0, 0x950, 0x0];
    public const uint PlayerB1S1Size = 344;
    public const uint BoxPadding = 0x40;

    public static IReadOnlyList<long> TradePartnerMyStatusPointer { get; } = [0x3EFD058, 0x1D8, 0x198, 0x68, 0x74];
    public static IReadOnlyList<long> TradePartnerNIDPointer      { get; } = [0x5F0E2B0, 0x108];
    public static IReadOnlyList<long> TradePartnerPokemonPointer  { get; } = [0x5F0E2B0, 0x128, 0x30, 0x0];

    public static IReadOnlyList<long> WildPokemonPointer          { get; } = [0x0];
}

