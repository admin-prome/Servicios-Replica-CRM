using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class GpTableroGantt
{
    public int IdTableroGantt { get; set; }

    public int IdTableros { get; set; }

    public DateTime Fecha { get; set; }

    public string? Responsable { get; set; }

    public string Tipo { get; set; } = null!;

    public string Accion { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? ResponsableAcción { get; set; }

    public string? Descripción { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public decimal? AvanceAcción { get; set; }

    public DateTime FechaCreación { get; set; }

    public DateTime FechaModificación { get; set; }

    public string? ModificadoPor { get; set; }

    public byte[] Stamp { get; set; } = null!;

    public virtual GpTablero IdTablerosNavigation { get; set; } = null!;
}
