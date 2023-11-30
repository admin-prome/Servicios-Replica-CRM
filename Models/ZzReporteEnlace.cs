using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class ZzReporteEnlace
{
    public int IdEnlace { get; set; }

    public string Pagina { get; set; } = null!;

    public string? Enlace { get; set; }

    public string? Area { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaModificacion { get; set; }

    public string ModificadoPor { get; set; } = null!;
}
