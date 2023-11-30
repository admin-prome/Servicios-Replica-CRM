using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PnetSitevisitBase
{
    public Guid? PnetSitevisitId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public Guid? CreatedOnBehalfBy { get; set; }

    public Guid? ModifiedOnBehalfBy { get; set; }

    public Guid? OwnerId { get; set; }

    public int? OwnerIdType { get; set; }

    public Guid? OwningBusinessUnit { get; set; }

    public int? Statecode { get; set; }

    public int? Statuscode { get; set; }

    public byte[]? VersionNumber { get; set; }

    public int? ImportSequenceNumber { get; set; }

    public DateTime? OverriddenCreatedOn { get; set; }

    public int? TimeZoneRuleVersionNumber { get; set; }

    public int? UtcconversionTimeZoneCode { get; set; }

    public string? PnetName { get; set; }

    public int? PnetCreditSubType { get; set; }

    public int? PnetCreditType { get; set; }

    public bool? PnetDirectFamily { get; set; }

    public double? PnetEstimatedAmount { get; set; }

    public string? PnetFateCredit { get; set; }

    public int? PnetFee { get; set; }

    public string? PnetFomrTypeRenovation { get; set; }

    public int? PnetFormTypeRenovation { get; set; }

    public string? PnetGetId { get; set; }

    public bool? PnetMiniTer { get; set; }

    public string? PnetNffateCredit { get; set; }

    public int? PnetNffee { get; set; }

    public bool? PnetOpportunityCreated { get; set; }

    public double? PnetPreapprovedAmount { get; set; }

    public double? PnetPreapprovedFee { get; set; }

    public string? PnetPrincipalApplication { get; set; }

    public int? PnetReportType { get; set; }

    public string? PnetSolNumber { get; set; }

    public int? PnetSvcreditSubType { get; set; }

    public int? PnetSvcreditType { get; set; }

    public string? PnetSvname { get; set; }

    public int? PnetSvreportType { get; set; }

    public DateTime? PnetVisitDate { get; set; }

    public Guid? PnetMicroEmpresa { get; set; }

    public Guid? PnetPrincipalApplicationId { get; set; }

    public Guid? PnetPrincipalContact { get; set; }

    public Guid? PnetSitevisitPrincipalApplicationId { get; set; }

    public Guid? PnetRenovationRequest { get; set; }

    public Guid? PnetSupplementaryRequest { get; set; }

    public Guid? PnetCounterId { get; set; }

    public Guid? PnetCommercialBackgroundId { get; set; }

    public Guid? PnetRequestId { get; set; }

    public Guid? PnetOwnerId { get; set; }

    public Guid? PnetSubsidiaryId { get; set; }

    public Guid? PnetEjecutiveResponsible { get; set; }

    public bool? PnetCancelOpportunityPrevious { get; set; }

    public bool? PnetCancelOpportunityPrevious2 { get; set; }

    public bool? PnetChangeCreditTypeorSubtype { get; set; }

    public int? PnetCloneType { get; set; }

    public Guid? PnetOpportunityGenerated { get; set; }

    public bool? PnetManualentryrequest { get; set; }

    public int? PnetRenovationResquestmanual { get; set; }

    public DateTime? PnetAssignmentDate { get; set; }

    public DateTime? PnetDateofvisitineffectivefield { get; set; }

    public string? PnetSiteVisitGps { get; set; }

    public Guid? PnetPapopp { get; set; }

    public int? PnetCreditDestination { get; set; }

    public bool? PnetInCampaign { get; set; }

    public double? PnetInterestRate { get; set; }

    public double? PnetQuotaAmount { get; set; }

    public int? PnetQuotasNumber { get; set; }

    public int? PnetSetValuesInterestRate { get; set; }

    public Guid? PnetCampaignId { get; set; }

    public Guid? PnetCampaignResponseId { get; set; }

    public Guid? PnetOfferByMemberId { get; set; }

    public string? PnetEstimatedAmountletters { get; set; }

    public Guid? PnetBankLoanAgreement { get; set; }

    public Guid? PnetCustomerregistration { get; set; }

    public int? PnetProcessEvaluate { get; set; }

    public Guid? PnetConvenio { get; set; }
}
