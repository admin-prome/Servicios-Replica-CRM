using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class TecMetrica
{
    public long IdMetricas { get; set; }

    public long IdObjetivo { get; set; }

    public long Legajo { get; set; }

    public DateTime Periodo { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaEntrega { get; set; }

    public decimal EsfuerzoEstimado { get; set; }

    public string EsfuerzoUnidad { get; set; } = null!;

    public decimal EsfuerzoAcumulado { get; set; }

    public decimal AvanceEstimado { get; set; }

    public decimal Meta { get; set; }

    public string? Observaciones { get; set; }

    public int IdEstado { get; set; }

    public DateTime? FechaCancelado { get; set; }

    public DateTime FechaInformada { get; set; }

    public DateTime FechaModificación { get; set; }

    public string? ModificadoPor { get; set; }

    public byte[] Stamp { get; set; } = null!;
}
