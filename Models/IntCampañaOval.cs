using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class IntCampañaOval
{
    public long? IdIntCampañas { get; set; }

    public string? Oval { get; set; }

    public DateTime? FechaOval { get; set; }

    public DateTime? FechaEnviado { get; set; }

    public string? Estado { get; set; }
}
