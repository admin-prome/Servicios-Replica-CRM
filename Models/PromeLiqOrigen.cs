using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PromeLiqOrigen
{
    public int Solicitud { get; set; }

    public string Origen { get; set; } = null!;

    public DateTime FechaProceso { get; set; }
}
