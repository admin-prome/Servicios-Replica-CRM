using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class GravityChoice
{
    public int SkForm { get; set; }

    public int SkField { get; set; }

    public int SkChoice { get; set; }

    public string? Value { get; set; }

    public string? Text { get; set; }

    public string ValorCrm { get; set; } = null!;

    public DateTime? Modificado { get; set; }

    public string? ModificadoPor { get; set; }
}
