using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class IntCampañasNotificar
{
    public long IdNotificar { get; set; }

    public string Archivo { get; set; } = null!;

    public string NotificarA { get; set; } = null!;

    public string? IdProceso { get; set; }

    public DateTime FechaProceso { get; set; }
}
