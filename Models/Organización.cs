using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class Organización
{
    public int SkArea { get; set; }

    public string? Zona { get; set; }

    public string? Gerencia { get; set; }

    public string? CentroDeCostos { get; set; }

    public string? SectorCodigo { get; set; }

    public string? SectorNombre { get; set; }

    public string? Mail { get; set; }

    public decimal? Latitud { get; set; }

    public decimal? Longitud { get; set; }

    public DateTime FechaCreación { get; set; }

    public DateTime? FechaModificación { get; set; }

    public string? ModificadoPor { get; set; }

    public long? SucursalCodigo { get; set; }

    public int? Activo { get; set; }
}
