using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furfrou.Core.Interfaces;

internal interface IGeneratorConfig
{
    
}

public class RadarContinuationConfig : IGeneratorConfig
{
    public int ContinueRate { get; set; } = 93;
}
