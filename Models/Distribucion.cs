using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class Distribucion
{
    public long IdDistribucion { get; set; }

    public DateTime Periodo { get; set; }

    public string Concepto { get; set; } = null!;

    public string Sucursal { get; set; } = null!;

    public decimal Valor { get; set; }

    public string? Archivo { get; set; }

    public string? IdProceso { get; set; }

    public DateTime? FechaProceso { get; set; }
}
