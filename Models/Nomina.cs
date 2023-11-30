using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class Nomina
{
    public int SkNomina { get; set; }

    public int SkArea { get; set; }

    public int? Legajo { get; set; }

    public string? Nombre { get; set; }

    public string? CategoriaCodigo { get; set; }

    public string? CategoriaNombre { get; set; }

    public string? Mail { get; set; }

    public string? Generación { get; set; }

    public string? Categoría { get; set; }

    public DateTime? FechaBaja { get; set; }

    public DateTime FechaCreación { get; set; }

    public DateTime? FechaModificación { get; set; }

    public string? ModificadoPor { get; set; }
}
