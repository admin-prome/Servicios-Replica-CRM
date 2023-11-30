using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class CorreoCopium
{
    public int IdCorreoCopia { get; set; }

    public string Tipo { get; set; } = null!;

    public string Destinatario { get; set; } = null!;

    public string CopiarA { get; set; } = null!;

    public DateTime FechaCreación { get; set; }

    public string ModificadoPor { get; set; } = null!;
}
