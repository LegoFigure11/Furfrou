using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furfrou.Core.Interfaces;

internal interface IBasicFrame
{
    string Advances { get; }
    string Seed0    { get; }
    string Seed1    { get; }
}

internal interface IRadarContinuationFrame
{
    char Fail  { get; }
    byte Roll  { get; }
}

public class RadarContinuationFrame : IBasicFrame, IRadarContinuationFrame
{
    public string Advances { get; set; } = string.Empty;

    public string Seed0    { get; set; } = string.Empty;
    public string Seed1    { get; set; } = string.Empty;

    public char Fail       { get; set; } = ' ';
    public byte Roll       { get; set; } = 0;
}

