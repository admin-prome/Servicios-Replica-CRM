using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class GpTableroKpi
{
    public int IdKpi { get; set; }

    public int IdTablero { get; set; }

    public DateTime Fecha { get; set; }

    public string NombreKpi { get; set; } = null!;

    public decimal Valor { get; set; }

    public decimal MetaMax { get; set; }

    public decimal MetaMin { get; set; }

    public string? Observaciones { get; set; }

    public DateTime FechaCreación { get; set; }

    public DateTime FechaModificación { get; set; }

    public string ModificadoPor { get; set; } = null!;

    public byte[] Stamp { get; set; } = null!;

    public virtual GpTablero IdTableroNavigation { get; set; } = null!;
}
