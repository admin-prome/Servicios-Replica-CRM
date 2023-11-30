using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PnetConveniosdecredito
{
    public string? CreatedByName { get; set; }

    public string? CreatedByYomiName { get; set; }

    public string? CreatedOnBehalfByName { get; set; }

    public string? CreatedOnBehalfByYomiName { get; set; }

    public string? ModifiedByName { get; set; }

    public string? ModifiedByYomiName { get; set; }

    public string? ModifiedOnBehalfByName { get; set; }

    public string? ModifiedOnBehalfByYomiName { get; set; }

    public string? PnetLineadecreditoName { get; set; }

    public string? PnetEvaluationprocessName { get; set; }

    public string? OrganizationIdName { get; set; }

    public Guid? PnetConveniosdecreditosId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public Guid? CreatedOnBehalfBy { get; set; }

    public Guid? ModifiedOnBehalfBy { get; set; }

    public Guid? OrganizationId { get; set; }

    public int? Statecode { get; set; }

    public int? Statuscode { get; set; }

    public byte[]? VersionNumber { get; set; }

    public int? ImportSequenceNumber { get; set; }

    public DateTime? OverriddenCreatedOn { get; set; }

    public int? TimeZoneRuleVersionNumber { get; set; }

    public int? UtcconversionTimeZoneCode { get; set; }

    public string? PnetName { get; set; }

    public int? PnetAcuerdo { get; set; }

    public int? PnetCodigodedestino { get; set; }

    public int? PnetDescripciondelproducto { get; set; }

    public int? PnetDestinodelcredito { get; set; }

    public Guid? PnetEvaluationprocess { get; set; }

    public Guid? PnetLineadecredito { get; set; }

    public int? PnetModalidad { get; set; }

    public double? PnetMontomaximo { get; set; }

    public double? PnetMontominimo { get; set; }

    public int? PnetPeriodicidadamortizacion { get; set; }

    public int? PnetPeriodicidaddeinteres { get; set; }

    public int? PnetPeriododegracia { get; set; }

    public int? PnetPlazomaximoenmeses { get; set; }

    public int? PnetPlazominimoenmeses { get; set; }

    public int? PnetProducto { get; set; }

    public bool? PnetRequiereaprobacion { get; set; }

    public int? PnetSistemadeamortizacion { get; set; }

    public double? PnetTasa { get; set; }

    public bool? PnetMindeproduccion { get; set; }
}
