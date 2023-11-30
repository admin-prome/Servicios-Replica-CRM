using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class Index
{
    public long IdIndice { get; set; }

    public string Cod { get; set; } = null!;

    public string Indice { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public DateTime Periodo { get; set; }

    public decimal Valor { get; set; }

    public string? Archivo { get; set; }

    public string? IdProceso { get; set; }

    public DateTime? FechaProceso { get; set; }
}
