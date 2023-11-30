using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class CuadroDiarioEjecutivo
{
    public DateTime? Mes { get; set; }

    public int? Vencimiento { get; set; }

    public string Zona { get; set; } = null!;

    public int SkArea { get; set; }

    public string? Subzona { get; set; }

    public string? Sucursal { get; set; }

    public long? SucursalCódigo { get; set; }

    public string? NombreEc { get; set; }

    public int? LegajoEc { get; set; }

    public int? SinPiloto { get; set; }

    public int? EcEvaluadorInconsistente { get; set; }

    public string? NombreEcEvaluador { get; set; }

    public int? LegajoEcEvaluador { get; set; }

    public string? NombreEcAdm { get; set; }

    public int? LegajoEcAdm { get; set; }

    public string? Quartile { get; set; }

    public DateTime? SkFecha { get; set; }

    public string? SubzonaCorregida { get; set; }

    public string? Solicitud { get; set; }

    public long SkPrestamo { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public long SkPersona { get; set; }

    public string? GrupoVencimiento { get; set; }

    public string? GrupoCompromiso { get; set; }

    public string? GrupoAtraso { get; set; }

    public DateTime? PróximaLiquidación { get; set; }

    public short Prematuro { get; set; }

    public short MoraAvanzada { get; set; }

    public int Futuros30 { get; set; }

    public short MontoMayor { get; set; }

    public string? TipoCobertura { get; set; }

    public decimal? FactorCobertura { get; set; }

    public decimal? SaldoCuenta { get; set; }

    public int? DíasAtraso { get; set; }

    public decimal? MontoCuota { get; set; }

    public int? Cuotas { get; set; }

    public string? Situación { get; set; }

    public string SituaciónNombre { get; set; } = null!;

    public decimal? SaldoMora { get; set; }

    public decimal? SaldoPréstamo { get; set; }

    public decimal? SaldoTotalPréstamos { get; set; }

    public decimal? DeudaExigible { get; set; }

    public long? NroDoc { get; set; }

    public string? TipoCrédito { get; set; }

    public string? SubTipoCrédito { get; set; }

    public int? Plazo { get; set; }

    public DateTime FechaProceso { get; set; }

    public string? ContactId { get; set; }

    public string? Te { get; set; }

    public string? PromesaPago { get; set; }

    public string? GrupoÚltimaGestion { get; set; }

    public DateTime? DiaHabil { get; set; }
}
