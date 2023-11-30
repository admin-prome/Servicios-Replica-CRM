using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class FechaFeriado
{
    public DateTime Fecha { get; set; }

    public string? Feriado { get; set; }

    public int Laborable { get; set; }

    public DateTime FechaCreación { get; set; }

    public DateTime? FechaModificación { get; set; }

    public string ModificadoPor { get; set; } = null!;
}
