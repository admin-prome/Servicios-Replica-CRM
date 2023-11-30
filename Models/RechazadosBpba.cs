using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class RechazadosBpba
{
    public long IdRechazado { get; set; }

    public string IdMensaje { get; set; } = null!;

    public string Encabezado { get; set; } = null!;

    public string Cuerpo { get; set; } = null!;

    public string Mensaje { get; set; } = null!;

    public DateTime Recibido { get; set; }

    public string Estado { get; set; } = null!;

    public string Desde { get; set; } = null!;

    public DateTime FechaCreación { get; set; }

    public DateTime FechaModificación { get; set; }

    public string? Archivo { get; set; }
}
