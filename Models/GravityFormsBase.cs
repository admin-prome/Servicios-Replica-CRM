using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class GravityFormsBase
{
    public int SkForm { get; set; }

    public long FormId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string Version { get; set; } = null!;

    public bool Configurado { get; set; }

    public DateTime Creado { get; set; }

    public DateTime? Modificado { get; set; }

    public string? ModificadoPor { get; set; }
}
