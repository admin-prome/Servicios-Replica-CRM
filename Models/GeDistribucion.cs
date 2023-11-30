using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class GeDistribucion
{
    public DateTime? Periodo { get; set; }

    public string Concepto { get; set; } = null!;

    public string? Sucursal { get; set; }

    public string? Categoría { get; set; }

    public decimal? QSuc { get; set; }

    public decimal? QTotal { get; set; }

    public decimal Ponderación { get; set; }

    public decimal? QSucPond { get; set; }

    public decimal? QTotPond { get; set; }

    public string? Valor { get; set; }

    public string? Archivo { get; set; }

    public string? IdProceso { get; set; }

    public DateTime? FechaProceso { get; set; }
}
