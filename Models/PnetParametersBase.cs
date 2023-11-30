using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PnetParametersBase
{
    public Guid? PnetParametersId { get; set; }

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

    public double? PnetGroupFactor { get; set; }

    public double? PnetMaximumAmount1 { get; set; }

    public double? PnetMaximumAmount2 { get; set; }

    public double? PnetMaximumAmount3 { get; set; }

    public double? PnetMaximumAmount4 { get; set; }

    public double? PnetMaximumCreditAmount { get; set; }

    public double? PnetQuote1 { get; set; }

    public double? PnetQuote2 { get; set; }

    public double? PnetSingleAmount { get; set; }

    public double? PnetSingleFactor { get; set; }

    public decimal? PnetAccmaintcost { get; set; }

    public decimal? PnetCostretirement { get; set; }

    public double? PnetNoPreferencialA { get; set; }

    public double? PnetNoPreferencialB { get; set; }

    public double? PnetNoPreferencialC { get; set; }

    public double? PnetNoPreferencialD { get; set; }

    public decimal? PnetOpperccomm { get; set; }

    public decimal? PnetPercli { get; set; }

    public decimal? PnetPerctaxa { get; set; }

    public decimal? PnetPerctaxb { get; set; }

    public double? PnetPreferencialA { get; set; }

    public double? PnetPreferencialB { get; set; }

    public double? PnetPreferencialC { get; set; }

    public double? PnetPreferencialD { get; set; }

    public string? PnetRecordCommittee { get; set; }

    public double? PnetRefinancingA { get; set; }

    public double? PnetRefinancingB { get; set; }

    public double? PnetRefinancingC { get; set; }

    public double? PnetRefinancingD { get; set; }

    public string? PnetRiskAnalisis { get; set; }

    public double? PnetSavingsAccountAmount { get; set; }

    public string? PnetUrl01 { get; set; }

    public string? PnetUrl02 { get; set; }

    public string? PnetUrl03 { get; set; }

    public string? PnetUrl04 { get; set; }

    public string? PnetUrl05 { get; set; }

    public string? PnetUrl06 { get; set; }

    public string? PnetUrl07 { get; set; }

    public string? PnetUrl08 { get; set; }

    public string? PnetUrl09 { get; set; }

    public int? PnetUrl1 { get; set; }

    public string? PnetUrl10 { get; set; }

    public string? PnetUrl11 { get; set; }

    public int? PnetDummyTonIndex { get; set; }

    public string? PnetIndexDomain { get; set; }

    public bool? PnetIndexhttps { get; set; }

    public string? PnetIndexlog { get; set; }

    public string? PnetIndexOrganization { get; set; }

    public string? PnetIndexPassword { get; set; }

    public string? PnetIndexPort { get; set; }

    public string? PnetIndexServer { get; set; }

    public string? PnetIndexUser { get; set; }

    public Guid? PnetOpportunityIndex { get; set; }

    public string? PnetGetAccountMovements { get; set; }

    public string? PnetGetispromeaccount { get; set; }

    public string? PnetGetLoanHistory { get; set; }

    public string? PnetGetProductsByNipProduct { get; set; }

    public Guid? PnetIndexSiteVisit { get; set; }

    public double? PnetPreApprovedAmount1 { get; set; }

    public double? PnetPreApprovedAmount2 { get; set; }

    public string? PnetOpportunityUrldoc { get; set; }

    public string? PnetAlertMontoCnmb { get; set; }

    public string? PnetAlertMontoRenoMb { get; set; }

    public double? PnetMaxMontoCnmb { get; set; }

    public double? PnetMaxMontoRenoMb { get; set; }

    public Guid? PnetRiskRole { get; set; }

    public Guid? PnetUccrole { get; set; }

    public Guid? PnetUccrrole { get; set; }

    public Guid? PnetCommercialassistantposition { get; set; }

    public Guid? PnetCommercialexecutiveposition { get; set; }

    public Guid? PnetInstanceRole { get; set; }

    public string? PnetQueryVeraz { get; set; }

    public string? PnetAlertmontocnmbesp { get; set; }

    public double? PnetSpecialamountunder { get; set; }

    public string? PnetUrlReportBp0934 { get; set; }

    public double? PnetNopreferenciale { get; set; }

    public double? PnetSmvm { get; set; }

    public double? PnetPreferencialf { get; set; }

    public bool? PnetAltaPromeVersion { get; set; }

    public Guid? PnetCallcenterposition { get; set; }

    public int? PnetDaysToSendOpps { get; set; }

    public int? PnetHoursToSendOpps { get; set; }

    public decimal? PnetMinimunAmountSmvm { get; set; }

    public int? PnetNormalizationMax { get; set; }

    public int? PnetPermanency { get; set; }

    public double? PnetPreferencialg { get; set; }

    public string? PnetUrlaltaDirecciones { get; set; }

    public string? PnetUrlaltaNip { get; set; }

    public string? PnetUrlaltaServiciosInternacionales { get; set; }

    public string? PnetUrlaltaTelefonos { get; set; }

    public string? PnetUrlconsultadeLegajo { get; set; }

    public string? PnetUrlconsultaNovedades { get; set; }

    public string? PnetUrlconsultaTelefonos { get; set; }

    public string? PnetUrlcreacionCajadeAhorro { get; set; }

    public string? PnetUrlentityMetadata { get; set; }

    public string? PnetUrlenvioaBancoBip { get; set; }

    public string? PnetUrlesCliente { get; set; }

    public string? PnetUrlesClienteBip { get; set; }

    public string? PnetUrlnormalizacion { get; set; }

    public string? PnetUrlreporteB510 { get; set; }

    public string? PnetUrlreporteBp730 { get; set; }

    public string? PnetUrlsincronizarDirecciones { get; set; }

    public string? PnetUrlvincularContacto { get; set; }

    public bool? PnetAutomaticcampaignexpiration { get; set; }

    public int? PnetXVencimientoCampaginresponse { get; set; }

    public int? PnetXVencimientoOffervalue { get; set; }

    public int? PnetDelaydays { get; set; }
}
