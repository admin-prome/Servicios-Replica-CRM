using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class SolicitudesExtra
{
    public string? Solicitud { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? NúmeroDeEmpleados { get; set; }

    public bool? Monto { get; set; }

    public string? TipoDeVivienda { get; set; }

    public bool? CambioDeMeEvaluada { get; set; }

    public string? ClasificaciónHistorialCrediticio { get; set; }

    public double? OtrosIngresos { get; set; }

    public string? ClasificaciónDePermanenciaMt { get; set; }

    public double? ClasificaciónPatrimonial { get; set; }

    public double? TotalUS { get; set; }

    public decimal? CapacidadDePagoAjustadaMesAlto { get; set; }

    public decimal? CapacidadDePagoAjustadaMesBajo { get; set; }

    public decimal? CapacidadDePagoAjustadaMesMedio { get; set; }

    public decimal? CapacidadDePagoMesAlto { get; set; }

    public decimal? CapacidadDePagoMesBajo { get; set; }

    public decimal? CapacidadDePagoMesMedio { get; set; }

    public decimal? CapacidadDePagoEnElPeríodo { get; set; }

    public bool? CuotasPagas { get; set; }

    public int? PermanenciaMeses { get; set; }

    public string? ClasificaciónDePermanencia { get; set; }

    public double? EducaciónPrivada { get; set; }

    public bool? ComportamientoProme { get; set; }

    public DateTime? FechaInscripciónAfip { get; set; }

    public bool? Renovación { get; set; }

    public double? Total { get; set; }

    public double? TotalGastoFamiliar { get; set; }

    public int? TotalGrupoFamiliar { get; set; }

    public double? TotalActivosFijos { get; set; }

    public double? CostoVariableMesAlto { get; set; }

    public double? CostoVariableMesBajo { get; set; }

    public double? CostoVariableMesMedio { get; set; }

    public double? SubTotal { get; set; }

    public double? Total11 { get; set; }

    public double? NúmeroDeClientesVariable { get; set; }

    public double? Vehículos { get; set; }

    public string? EjecutivoEvaluador { get; set; }

    public string? EjecutivoColegiador { get; set; }

    public string? EjecutivoSupervisor { get; set; }

    public double? Total1 { get; set; }

    public bool? DentroDeCampaña { get; set; }

    public string? SistemaDeAmortización { get; set; }

    public int? Formal { get; set; }

    public string? ImpactaSóloARm { get; set; }

    public int? Independiente { get; set; }

    public int? Informal { get; set; }

    public bool? Llapre { get; set; }

    public bool? Llare { get; set; }

    public string? OpCreditSubType { get; set; }

    public string? TipoDeCréditoOp { get; set; }

    public string? MicroEmpresa { get; set; }

    public Guid? BkMicroEmpresa { get; set; }

    public double? TasaDeInterésAnual { get; set; }

    public bool? RequiereRiesgo { get; set; }

    public bool? Agro { get; set; }

    public string? ResultadosScoreDePuntaje { get; set; }

    public bool? AutorizaciónJefeZonal { get; set; }

    public bool? AumentoDisminuciónCpCpa { get; set; }

    public bool? BasesNegativasObs { get; set; }

    public bool? DeudasHistorialCrediticioNivelEndeudamiento { get; set; }

    public string? PeríodoDeAmortización { get; set; }

    public string? Descripción { get; set; }

    public string? DestinoDelCrédito { get; set; }

    public string? ObservaciónSobreSolidezPatrimonial { get; set; }

    public string? ObservacionesSobrePermanenciaDelNegocio { get; set; }

    public string? ObservacionesDeCostosVariables { get; set; }

    public string? DescripciónDelNegocio { get; set; }

    public string? ObservacionesSobreHistorialCrediticio { get; set; }

    public string? Motivadores { get; set; }

    public string? Debilidades { get; set; }

    public string? ObservacionesSobreGrupoFamiliarVivienda { get; set; }

    public string? FocoDeRiesgosYCómoSeMinimizan { get; set; }

    public string? FocoDeRiesgo { get; set; }

    public string? ObservacionesSobreComercialización { get; set; }
}
