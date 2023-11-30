using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class TecKpi
{
    public DateTime? Periodo { get; set; }

    public string Area { get; set; } = null!;

    public long? IdObjetivoSuperior { get; set; }

    public long? IdObjetivo { get; set; }

    public decimal? Cumplimiento { get; set; }

    public decimal? CumplimientoEsperado { get; set; }

    public decimal? Desvío { get; set; }

    public decimal Meta { get; set; }

    public decimal? Esfuerzo { get; set; }

    public decimal? DesvíoEsfuerzo { get; set; }

    public int? DesvíoEstimado { get; set; }

    public int? DesvíoProyectado { get; set; }

    public decimal? EsfuerzoEstimado { get; set; }

    public decimal? EsfuerzoAcumulado { get; set; }

    public string? EsfuerzoUnidad { get; set; }

    public decimal? CalidadInfo { get; set; }

    public int Nivel { get; set; }
}
