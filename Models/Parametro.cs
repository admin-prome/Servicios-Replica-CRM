using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class Parametro
{
    public long IdParametro { get; set; }

    public string Parametro1 { get; set; } = null!;

    public string Valor { get; set; } = null!;

    public decimal Ponderación { get; set; }

    public DateTime Periodo { get; set; }
}
