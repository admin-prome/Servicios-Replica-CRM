using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class GpTablero
{
    public int IdTableros { get; set; }

    public DateTime Fecha { get; set; }

    public string? Area { get; set; }

    public string Proyecto { get; set; } = null!;

    public string? Responsable { get; set; }

    public string? Descripción { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public DateTime? FechaFinReal { get; set; }

    public int IdEstado { get; set; }

    public DateTime FechaCreación { get; set; }

    public DateTime FechaModificación { get; set; }

    public string? ModificadoPor { get; set; }

    public byte[] Stamp { get; set; } = null!;

    public virtual ICollection<GpTableroGantt> GpTableroGantts { get; set; } = new List<GpTableroGantt>();

    public virtual ICollection<GpTableroKpi> GpTableroKpis { get; set; } = new List<GpTableroKpi>();
}
