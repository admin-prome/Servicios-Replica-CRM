using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class CampaignResponse
{
    public string? PnetInteractionSubStatusName { get; set; }

    public string? PnetInteractionSaleSubStatusName { get; set; }

    public string? PnetContactIdYomiName { get; set; }

    public string? PnetContactIdName { get; set; }

    public string? PnetContactOwnerYomiName { get; set; }

    public string? PnetContactOwnerName { get; set; }

    public string? PnetTopicIdName { get; set; }

    public string? PnetInteractionSaleStatusName { get; set; }

    public string? PnetCampaniaRespuestaIdName { get; set; }

    public string? PnetRenovationRequestIdName { get; set; }

    public string? PnetExecutiveNameIdYomiName { get; set; }

    public string? PnetExecutiveNameIdName { get; set; }

    public string? CreatedOnBehalfByName { get; set; }

    public string? CreatedOnBehalfByYomiName { get; set; }

    public string? PnetInteractionStatusName { get; set; }

    public string? TransactionCurrencyIdName { get; set; }

    public string? CreatedByName { get; set; }

    public string? CreatedByYomiName { get; set; }

    public string? PnetSaleStatusName { get; set; }

    public string? PnetSaleSubStatusName { get; set; }

    public string? ModifiedOnBehalfByYomiName { get; set; }

    public string? ModifiedOnBehalfByName { get; set; }

    public string? PnetBusinessUnitName { get; set; }

    public string? OriginatingActivityName { get; set; }

    public string? ModifiedByYomiName { get; set; }

    public string? ModifiedByName { get; set; }

    public string? PnetOfferValueIdName { get; set; }

    public Guid? OwnerId { get; set; }

    public string? OwnerIdName { get; set; }

    public string? OwnerIdYomiName { get; set; }

    public int? OwnerIdDsc { get; set; }

    public int? OwnerIdType { get; set; }

    public Guid? OwningUser { get; set; }

    public Guid? OwningTeam { get; set; }

    public bool? IsBilled { get; set; }

    public Guid? OwningBusinessUnit { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? StatusCode { get; set; }

    public bool? IsWorkflowCreated { get; set; }

    public string? LastName { get; set; }

    public string? PromotionCodeName { get; set; }

    public DateTime? ActualStart { get; set; }

    public string? Fax { get; set; }

    public string? Category { get; set; }

    public DateTime? ScheduledEnd { get; set; }

    public int? PriorityCode { get; set; }

    public DateTime? ScheduledStart { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? RegardingObjectId { get; set; }

    public string? Telephone { get; set; }

    public int? ResponseCode { get; set; }

    public int? ActualDurationMinutes { get; set; }

    public string? Subcategory { get; set; }

    public string? CompanyName { get; set; }

    public int? ChannelTypeCode { get; set; }

    public string? FirstName { get; set; }

    public Guid? ActivityId { get; set; }

    public string? EmailAddress { get; set; }

    public Guid? ServiceId { get; set; }

    public DateTime? ActualEnd { get; set; }

    public int? ScheduledDurationMinutes { get; set; }

    public DateTime? ReceivedOn { get; set; }

    public Guid? OriginatingActivityId { get; set; }

    public int? StateCode { get; set; }

    public byte[]? VersionNumber { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public string? Subject { get; set; }

    public string? Description { get; set; }

    public string? RegardingObjectIdName { get; set; }

    public int? RegardingObjectTypeCode { get; set; }

    public int? OriginatingActivityIdTypeCode { get; set; }

    public int? UtcconversionTimeZoneCode { get; set; }

    public int? TimeZoneRuleVersionNumber { get; set; }

    public DateTime? OverriddenCreatedOn { get; set; }

    public int? ImportSequenceNumber { get; set; }

    public string? YomiLastName { get; set; }

    public string? YomiFirstName { get; set; }

    public string? RegardingObjectIdYomiName { get; set; }

    public string? YomiCompanyName { get; set; }

    public Guid? CreatedOnBehalfBy { get; set; }

    public Guid? ModifiedOnBehalfBy { get; set; }

    public int? ActivityTypeCode { get; set; }

    public bool? IsRegularActivity { get; set; }

    public Guid? TransactionCurrencyId { get; set; }

    public decimal? ExchangeRate { get; set; }

    public Guid? ProcessId { get; set; }

    public Guid? StageId { get; set; }

    public string? TraversedPath { get; set; }

    public string? ActivityAdditionalParams { get; set; }

    public int? PnetAgreement { get; set; }

    public int? PnetAmountRange { get; set; }

    public double? PnetCreditAmount { get; set; }

    public double? PnetCreditAmountNegotiation { get; set; }

    public int? PnetCreditDestination { get; set; }

    public string? PnetCreditTypification { get; set; }

    public string? PnetInteractionDescription { get; set; }

    public int? PnetInteractionQuotasNumber { get; set; }

    public double? PnetInterestRate { get; set; }

    public double? PnetInterestRateAnual { get; set; }

    public double? PnetNpa { get; set; }

    public double? PnetNpb { get; set; }

    public double? PnetNpc { get; set; }

    public double? PnetNpd { get; set; }

    public double? PnetOfferValueCreditAmount { get; set; }

    public double? PnetOfferValueQuotaAmount { get; set; }

    public double? PnetPa { get; set; }

    public double? PnetPb { get; set; }

    public double? PnetPc { get; set; }

    public double? PnetPd { get; set; }

    public int? PnetQuotasNumber { get; set; }

    public double? PnetQuotaValue { get; set; }

    public double? PnetQuotaValueNegotiation { get; set; }

    public int? PnetRate { get; set; }

    public double? PnetRb { get; set; }

    public double? PnetRc { get; set; }

    public double? PnetRd { get; set; }

    public bool? PnetRequireSiteVisit { get; set; }

    public double? PnetSaa { get; set; }

    public int? PnetSchema { get; set; }

    public int? PnetSetValuesInterestRate { get; set; }

    public int? PnetSubStatusCode { get; set; }

    public int? PnetTermRanges { get; set; }

    public Guid? PnetCampaniaRespuestaId { get; set; }

    public Guid? PnetContactId { get; set; }

    public Guid? PnetTopicId { get; set; }

    public Guid? PnetInteractionStatus { get; set; }

    public Guid? PnetInteractionSubStatus { get; set; }

    public Guid? PnetOfferValueId { get; set; }

    public Guid? PnetInteractionSaleStatus { get; set; }

    public Guid? PnetSaleStatus { get; set; }

    public Guid? PnetInteractionSaleSubStatus { get; set; }

    public Guid? PnetSaleSubStatus { get; set; }

    public int? PnetBuyingPropensity { get; set; }

    public Guid? PnetBusinessUnit { get; set; }

    public Guid? PnetExecutiveNameId { get; set; }

    public Guid? PnetContactOwner { get; set; }

    public bool? PnetManualEntreyRequest { get; set; }

    public int? PnetRenovationRequestManual { get; set; }

    public bool? PnetShowCloseCampaignFlag { get; set; }

    public Guid? PnetRenovationRequestId { get; set; }

    public double? PnetPe { get; set; }

    public double? PnetPf { get; set; }

    public double? PnetPg { get; set; }

    public DateTime? PnetFechafin { get; set; }

    public DateTime? PnetFechainicio { get; set; }

    public Guid? PnetConvenio { get; set; }

    public double? PnetTasa { get; set; }
}
