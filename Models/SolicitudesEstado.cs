using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class SolicitudesEstado
{
    public string? Solicitud { get; set; }

    public DateTime? FechaModificaciónSolicitud { get; set; }

    public int? StatusCode { get; set; }

    public int? StateCode { get; set; }

    public string Estatus { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public int? PnetSuraccount { get; set; }
}
