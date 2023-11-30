using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class ControlCorreo
{
    public int IdControlCorreos { get; set; }

    public string Correo { get; set; } = null!;

    public DateTime FechaCreación { get; set; }
}
