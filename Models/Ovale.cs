using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class Ovale
{
    public string? TipoDeCampaña { get; set; }

    public string? CódigoDeCampaña { get; set; }

    public string NombreDeCampaña { get; set; } = null!;

    public string? CódigoDeCampaña2 { get; set; }

    public string? TipoDeCliente { get; set; }

    public string? TipoDeFormulario { get; set; }

    public int? XVencimientoCampaginResponse { get; set; }

    public int? XVencimientoOfferValue { get; set; }

    public DateTime? FechaDeInicioReal { get; set; }

    public DateTime? FechaDeFinalizaciónReal { get; set; }

    public DateTime? CreatedOnCampaign { get; set; }

    public DateTime? ModifiedOnCampaign { get; set; }

    public string? StateCodeCampaign { get; set; }

    public string? StatusCodeCampaign { get; set; }

    public string? OfertaDeValor { get; set; }

    public string? EquipoPropietario { get; set; }

    public string? Propietario { get; set; }

    public string? EjecutivoComercial { get; set; }

    public string? EstadoDeVentaDeLaGestión { get; set; }

    public string? EstadoDeVenta { get; set; }

    public string? SubEstadoDeLaVenta { get; set; }

    public string? Zona { get; set; }

    public int? RangoDeMonto { get; set; }

    public double? MontoDeCréditoDeLaGestión { get; set; }

    public double? MontoDeCréditoDeLaOfertaDeValor { get; set; }

    public double? MontoDeCuotaDeLaOfertaDeValor { get; set; }

    public int? NúmeroDeCuotas { get; set; }

    public double? MontoDeCuota { get; set; }

    public double? ValorDeCuotaDeLaGestión { get; set; }

    public double? Tasa { get; set; }

    public string? DestinoDelCrédito { get; set; }

    public string? TipificaciónDeCrédito { get; set; }

    public int? NúmeroDeCuotasDeLaGestión { get; set; }

    public double? TasaDeInterésMensual { get; set; }

    public double? TasaDeInterésAnual { get; set; }

    public double? Npa { get; set; }

    public double? Npb { get; set; }

    public double? Npc { get; set; }

    public double? Npd { get; set; }

    public double? Pa { get; set; }

    public double? Pb { get; set; }

    public double? Pc { get; set; }

    public double? Pd { get; set; }

    public int? TasaGestión { get; set; }

    public double? Rb { get; set; }

    public double? Rc { get; set; }

    public double? Rd { get; set; }

    public double? Pe { get; set; }

    public double? Pf { get; set; }

    public double? Pg { get; set; }

    public bool? RequiereVisitaEnTerreno { get; set; }

    public int? RangosDeTérmino { get; set; }

    public DateTime? ComienzoRealGestión { get; set; }

    public DateTime? FinRealGestión { get; set; }

    public DateTime? CreatedOnCampaignResponse { get; set; }

    public DateTime? ModifiedOnCampaignResponse { get; set; }

    public string? StateCodeCampaignResponse { get; set; }

    public string? StatusCodeCampaignResponse { get; set; }

    public string? Solicitud { get; set; }

    public int? PnetSuraccount { get; set; }

    public DateTime? FechaLiquidación { get; set; }

    public double? Monto { get; set; }

    public bool? PnetInCampaign { get; set; }

    public string? StateCodeListmembers { get; set; }

    public string? StatusCodeListmembers { get; set; }

    public int? DocNro { get; set; }

    public string? DocTipo { get; set; }

    public string? Nacionalidad { get; set; }

    public string? Apellido { get; set; }

    public string? Nombres { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public int? SexoCód { get; set; }

    public string? EmailAddress { get; set; }

    public string? Celular { get; set; }

    public string? Teléfono { get; set; }

    public string? TeléfonoConsolidado { get; set; }

    public string? AreaCód1 { get; set; }

    public string? Tel1 { get; set; }

    public string? AreaCód2 { get; set; }

    public string? Tel2 { get; set; }

    public string? AreaCód3 { get; set; }

    public string? Tel3 { get; set; }

    public string? Calle { get; set; }

    public int? CalleNro { get; set; }

    public string? Bpbacalle { get; set; }

    public string? BpbacalleNro { get; set; }

    public string? BpbacalleCp { get; set; }

    public string? Bpbapersona { get; set; }

    public DateTime? FechaModificaciónSolicitud { get; set; }

    public DateTime? FechaModificaciónContacto { get; set; }

    public bool CalificaBip { get; set; }

    public int? ConvenioCampaignResponse { get; set; }

    public Guid? PnetConvenio { get; set; }

    public Guid? PnetContactId { get; set; }

    public string? CómoSeEnteró { get; set; }

    public string? SucursalPropietaria { get; set; }

    public string? FilialBpbaPropietaria { get; set; }

    public string? SucursalCódigoPropietaria { get; set; }

    public string? Legajo { get; set; }

    public string? Nif { get; set; }
}
