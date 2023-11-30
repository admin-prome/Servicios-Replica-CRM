using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class TcgMetricasCalculo
{
    public long IdObjetivo { get; set; }

    public long? IdObjetivoPredecesor { get; set; }

    public long Idmetricas { get; set; }

    public string Area { get; set; } = null!;

    public string NombreMétrica { get; set; } = null!;

    public DateTime Periodo { get; set; }

    public string EsfuerzoUnidad { get; set; } = null!;

    public decimal EsfuerzoEstimado { get; set; }

    public decimal EsfuerzoAcumulado { get; set; }

    public decimal Meta { get; set; }

    public decimal AvanceEstimado { get; set; }

    public decimal? Cumplimiento { get; set; }

    public decimal? CumplimientoEsperado { get; set; }

    public decimal? Esfuerzo { get; set; }

    public decimal? DesvíoEsfuerzo { get; set; }

    public DateTime FechaInformada { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaEntrega { get; set; }

    public int? ActualInfo { get; set; }

    public decimal? CalidadInfo { get; set; }

    public DateTime? EntregaProyectada { get; set; }

    public int? DesvíoProyectado { get; set; }

    public DateTime? EntregaEstimada { get; set; }

    public int? DesvíoEstimado { get; set; }
}
