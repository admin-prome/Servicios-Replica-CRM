using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class RechazadosBpba1
{
    public string? IdMensaje { get; set; }

    public string? Encabezado { get; set; }

    public string? Cuerpo { get; set; }

    public string? Recibido { get; set; }

    public string? Desde { get; set; }

    public DateTime FechaCreación { get; set; }
}
