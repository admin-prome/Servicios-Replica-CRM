using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class ZzSolicitudesHistorico
{
    public DateTime? Periodo { get; set; }

    public string? Zona { get; set; }

    public string? SubZonaNombre { get; set; }

    public string? SubZonaId { get; set; }

    public short? FilialBpba { get; set; }

    public int? FilialProme { get; set; }

    public string? Sucursal { get; set; }

    public int? LegajoEcEval { get; set; }

    public string? NombreEcEval { get; set; }

    public int? LegajoEcAdmin { get; set; }

    public string? NombreEcAdmin { get; set; }

    public int? LegajoEcAsigna { get; set; }

    public string? NombreEcAsigna { get; set; }

    public int? Solicitud { get; set; }

    public string? NombreCliente { get; set; }

    public DateTime? FechaOtorgamiento { get; set; }

    public DateTime? FechaApertura { get; set; }

    public decimal? MontoOtorgado { get; set; }

    public short? Plazo { get; set; }

    public decimal? Tasa { get; set; }

    public string? SubTipoCredito { get; set; }

    public long? NroCtaSur { get; set; }

    public short? TipCtaSur { get; set; }

    public string? GeneracionEcAdmin { get; set; }

    public int? Semana { get; set; }
}
