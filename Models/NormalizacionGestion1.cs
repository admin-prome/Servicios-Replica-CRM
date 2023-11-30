using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class NormalizacionGestion1
{
    public string? Zona { get; set; }

    public string? FilialBpba { get; set; }

    public string? Sucursal { get; set; }

    public int? LegajoAdmin { get; set; }

    public string? NombreAdmin { get; set; }

    public int? LegajoAsigna { get; set; }

    public string? NombreAsigna { get; set; }

    public string? Solicitud { get; set; }

    public string? TipoCredito { get; set; }

    public string? SubTipoCredito { get; set; }

    public long? NroDoc { get; set; }

    public string Titular { get; set; } = null!;

    public decimal? SaldoCuenta { get; set; }

    public decimal? DeudaExigible { get; set; }

    public decimal DeudaConsolidada { get; set; }

    public decimal? TotalCuota { get; set; }

    public DateTime? FechaOtorgamiento { get; set; }

    public int? CantidadCuotas { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public int? DiasAtraso { get; set; }

    public int? FechaCompromiso { get; set; }

    public DateTime? FechaProximaLiquidacion { get; set; }

    public decimal? SaldoPrestamo { get; set; }

    public decimal SaldoConsolidado { get; set; }

    public DateTime? FechaUltimoMovimiento { get; set; }

    public int? Plazo { get; set; }

    public int PrestamosMora { get; set; }

    public int PrestamosVigentes { get; set; }

    public string? TelefonoBpba { get; set; }

    public string? TelefonoCrm { get; set; }

    public string AfectaTda { get; set; } = null!;

    public string AfectaTmv { get; set; } = null!;

    public string Domicilio { get; set; } = null!;

    public string? Localidad { get; set; }

    public string? CodigoPostal { get; set; }

    public string Url { get; set; } = null!;

    public string? Hogar { get; set; }

    public string? Microempresa { get; set; }

    public string? EcDiasAccion { get; set; }

    public string? EcTipiAccion { get; set; }

    public string? EcDiasVisita { get; set; }

    public string? EcTipiVisita { get; set; }

    public string? CallDiasAccion { get; set; }

    public string? CallTipiAccion { get; set; }

    public string? RiesgoDiasAccion { get; set; }

    public string? RiesgoTipiAccion { get; set; }

    public string? RiesgoDiasVisita { get; set; }

    public string? RiesgoTipiVisit { get; set; }

    public string? GrupoVencimiento { get; set; }
}
