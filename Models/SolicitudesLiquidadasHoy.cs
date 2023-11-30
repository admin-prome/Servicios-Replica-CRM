using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class SolicitudesLiquidadasHoy
{
    public string? Solicitud { get; set; }

    public int? PnetSuraccount { get; set; }

    public DateTime? FechaLiquidación { get; set; }

    public double? Monto { get; set; }

    public DateTime? FechaModificaciónSolicitud { get; set; }
}
