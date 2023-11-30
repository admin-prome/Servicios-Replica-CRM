using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class NominaCategoriaColocacione
{
    public double? MontoTotal { get; set; }

    public int? CantidadTotal { get; set; }

    public string? Ejecutivo { get; set; }

    public string? Sucursal { get; set; }

    public string? Zona { get; set; }

    public string Tipo { get; set; } = null!;

    public decimal? Tasa { get; set; }

    public string? TipoCrédito { get; set; }

    public string? SubTipoCrédito { get; set; }

    public string? CategoriaNombre { get; set; }

    public int? Legajo { get; set; }

    public int? BimestreDelAño { get; set; }

    public string? BimestreDelAñoNombre { get; set; }

    public DateTime? Bimestre { get; set; }
}
