using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class NominaArea
{
    public int? Legajo { get; set; }

    public string? Nombre { get; set; }

    public string? CategoriaCodigo { get; set; }

    public string? CategoriaNombre { get; set; }

    public string? Categoría { get; set; }

    public string? Generación { get; set; }

    public string? Mail { get; set; }

    public string? Zona { get; set; }

    public string? Gerencia { get; set; }

    public string? CentroDeCostos { get; set; }

    public string? SectorCodigo { get; set; }

    public string? SectorNombre { get; set; }

    public string? AreaMail { get; set; }

    public decimal? Latitud { get; set; }

    public decimal? Longitud { get; set; }
}
