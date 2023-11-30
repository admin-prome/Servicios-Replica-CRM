using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class Presentismo
{
    public long IdPresentismo { get; set; }

    public int? BkId { get; set; }

    public string? Motivo { get; set; }

    public string? Estado { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Destino { get; set; }

    public decimal? Km { get; set; }

    public string? Concepto { get; set; }

    public string? CargadoEnCelular { get; set; }

    public int? Legajo { get; set; }

    public string? Email { get; set; }

    public string? CategoriaCodigo { get; set; }

    public double? Latitud { get; set; }

    public double? Longitud { get; set; }

    public string? Zona { get; set; }

    public string? Gerencia { get; set; }

    public string? CentroDeCostos { get; set; }

    public string? SectorNombre { get; set; }

    public string? SectorCodigo { get; set; }

    public decimal? LatitudSucursal { get; set; }

    public decimal? LongitudSucursal { get; set; }
}
