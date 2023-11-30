using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class CorreoPlantilla
{
    public int IdPlantilla { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Notas { get; set; }

    public string Asunto { get; set; } = null!;

    public string Html { get; set; } = null!;

    public string Categoría { get; set; } = null!;

    public bool Activa { get; set; }

    public DateTime Modificado { get; set; }

    public string ModificadoPor { get; set; } = null!;

    public string Sector { get; set; } = null!;
}
