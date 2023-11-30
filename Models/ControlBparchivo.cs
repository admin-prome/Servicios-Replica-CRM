using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class ControlBparchivo
{
    public long IdBparchivos { get; set; }

    public string Archivo { get; set; } = null!;

    public string Carpeta { get; set; } = null!;

    public DateTime FechaCreación { get; set; }

    public int DíasEliminación { get; set; }

    public DateTime? FechaEliminación { get; set; }
}
