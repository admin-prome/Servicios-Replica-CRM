using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class Solicitude
{
    public string? Solicitud { get; set; }

    public int? PnetSuraccount { get; set; }

    public DateTime? FechaLiquidación { get; set; }

    public double? Monto { get; set; }

    public string? Zona { get; set; }

    public string? Subzona { get; set; }

    public string? Sucursal { get; set; }

    public string? SucursalCód { get; set; }

    public string? Ec { get; set; }

    public string? LegajoEc { get; set; }

    public string Estado { get; set; } = null!;

    public string? Instancia { get; set; }

    public string? SubInstancia { get; set; }

    public string Origen { get; set; } = null!;

    public decimal? TasaAnual { get; set; }

    public string? TipoFormulario { get; set; }

    public string? TipoCrédito { get; set; }

    public string? SubTipoCrédito { get; set; }

    public string? Score { get; set; }

    public string? DocTipo { get; set; }

    public int? DocNro { get; set; }

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

    public string? Destino { get; set; }

    public bool CalificaBip { get; set; }

    public Guid? ContactId { get; set; }

    public Guid? PnetSiteVisitNumber { get; set; }

    public Guid? PnetCampaignResponseId { get; set; }

    public int? PnetAgreement { get; set; }

    public bool? PnetCreditocongarantiafogaba { get; set; }

    public string? JefeZonalAprobación { get; set; }

    public string? JefeZonalLegajo { get; set; }

    public DateTime? FechaCreaciónSolicitud { get; set; }

    public string? Municipio { get; set; }

    public string? Localidad { get; set; }

    public string? CómoSeEnteró { get; set; }

    public int? NúmeroDeCuotas { get; set; }

    public int? NivelDeExcepción { get; set; }

    public bool? CambioDeMeEvaluada { get; set; }

    public bool? CuotasPagasSN { get; set; }

    public bool? ComportamientoProme { get; set; }

    public bool? SolidezPatrimonial { get; set; }

    public string? Nif { get; set; }
}
