using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class ReportePresentismo
{
    public string? Motivo { get; set; }

    public string? Estado { get; set; }

    public DateTime? Fecha { get; set; }

    public DateTime? SkFecha { get; set; }

    public string? Destino { get; set; }

    public decimal? Km { get; set; }

    public string? Concepto { get; set; }

    public string? CargadoEnCelular { get; set; }

    public string? Legajo { get; set; }

    public string? Nombre { get; set; }

    public string? Email { get; set; }

    public double? Latitud { get; set; }

    public double? Longitud { get; set; }

    public string? Zona { get; set; }

    public string? Gerencia { get; set; }

    public string? CentroDeCostos { get; set; }

    public string? SectorNombre { get; set; }

    public string? SectorCodigo { get; set; }

    public decimal? LatitudSucursal { get; set; }

    public decimal? LongitudSucursal { get; set; }

    public string Tipo { get; set; } = null!;

    public int Tamaño { get; set; }

    public double? Distancia { get; set; }
}
