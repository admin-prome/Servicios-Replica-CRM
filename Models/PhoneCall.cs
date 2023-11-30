using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PhoneCall
{
    public string? PnetCommercialBackgroundIdName { get; set; }

    public string? PnetContactIdYomiName { get; set; }

    public string? PnetOfferValueIdName { get; set; }

    public string? PnetInteractionStatusName { get; set; }

    public string? PnetLeadIdYomiName { get; set; }

    public string? PnetUserDirectionForName { get; set; }

    public string? PnetTeamDirectionForYomiName { get; set; }

    public string? Slaname { get; set; }

    public string? SlainvokedIdName { get; set; }

    public string? PnetNegativeFolderBaseIdName { get; set; }

    public string? ModifiedOnBehalfByName { get; set; }

    public string? PnetOfertaValorIndividualIdName { get; set; }

    public string? CreatedByYomiName { get; set; }

    public string? PnetBusinessUnitName { get; set; }

    public string? PnetContactIdName { get; set; }

    public string? PnetSaleStatusName { get; set; }

    public string? PnetLeadIdName { get; set; }

    public string? CreatedOnBehalfByYomiName { get; set; }

    public string? PnetInteractionSubStatusName { get; set; }

    public string? PnetUserDirectionForYomiName { get; set; }

    public string? PnetTeamDirectionForName { get; set; }

    public string? ModifiedByName { get; set; }

    public string? PnetSaleSubStatusName { get; set; }

    public string? CreatedByName { get; set; }

    public string? ModifiedOnBehalfByYomiName { get; set; }

    public string? ModifiedByYomiName { get; set; }

    public string? TransactionCurrencyIdName { get; set; }

    public string? CreatedOnBehalfByName { get; set; }

    public Guid? OwnerId { get; set; }

    public string? OwnerIdName { get; set; }

    public string? OwnerIdYomiName { get; set; }

    public int? OwnerIdDsc { get; set; }

    public int? OwnerIdType { get; set; }

    public Guid? OwningUser { get; set; }

    public Guid? OwningTeam { get; set; }

    public string? Subject { get; set; }

    public Guid? ModifiedBy { get; set; }

    public Guid? OwningBusinessUnit { get; set; }

    public DateTime? ActualEnd { get; set; }

    public Guid? ActivityId { get; set; }

    public Guid? CreatedBy { get; set; }

    public string? PhoneNumber { get; set; }

    public bool? DirectionCode { get; set; }

    public Guid? RegardingObjectId { get; set; }

    public bool? IsBilled { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public DateTime? ScheduledEnd { get; set; }

    public DateTime? CreatedOn { get; set; }

    public byte[]? VersionNumber { get; set; }

    public bool? IsWorkflowCreated { get; set; }

    public int? PriorityCode { get; set; }

    public DateTime? ActualStart { get; set; }

    public string? Category { get; set; }

    public int? ScheduledDurationMinutes { get; set; }

    public string? Description { get; set; }

    public int? StateCode { get; set; }

    public string? Subcategory { get; set; }

    public int? ActualDurationMinutes { get; set; }

    public int? StatusCode { get; set; }

    public DateTime? ScheduledStart { get; set; }

    public Guid? ServiceId { get; set; }

    public string? RegardingObjectIdName { get; set; }

    public int? RegardingObjectTypeCode { get; set; }

    public int? ImportSequenceNumber { get; set; }

    public DateTime? OverriddenCreatedOn { get; set; }

    public int? TimeZoneRuleVersionNumber { get; set; }

    public int? UtcconversionTimeZoneCode { get; set; }

    public Guid? SubscriptionId { get; set; }

    public string? RegardingObjectIdYomiName { get; set; }

    public Guid? CreatedOnBehalfBy { get; set; }

    public Guid? ModifiedOnBehalfBy { get; set; }

    public int? ActivityTypeCode { get; set; }

    public bool? IsRegularActivity { get; set; }

    public Guid? TransactionCurrencyId { get; set; }

    public decimal? ExchangeRate { get; set; }

    public bool? LeftVoiceMail { get; set; }

    public Guid? ProcessId { get; set; }

    public Guid? StageId { get; set; }

    public string? TraversedPath { get; set; }

    public string? ActivityAdditionalParams { get; set; }

    public Guid? SlainvokedId { get; set; }

    public int? OnHoldTime { get; set; }

    public DateTime? LastOnHoldTime { get; set; }

    public Guid? Slaid { get; set; }

    public DateTime? SortDate { get; set; }

    public int? PnetDocumentNumber { get; set; }

    public int? PnetDocumentType { get; set; }

    public int? PnetIncomingTypes1 { get; set; }

    public int? PnetIncomingTypes2 { get; set; }

    public int? PnetOutgoingTypes1 { get; set; }

    public int? PnetOutgoingTypes2 { get; set; }

    public DateTime? PnetReschedulePending { get; set; }

    public Guid? PnetContactId { get; set; }

    public Guid? PnetNegativeFolderBaseId { get; set; }

    public int? PnetAgreement { get; set; }

    public int? PnetAmountRange { get; set; }

    public double? PnetCreditAmount { get; set; }

    public double? PnetCreditAmountCampaign { get; set; }

    public int? PnetCreditDestination { get; set; }

    public string? PnetCreditTypification { get; set; }

    public bool? PnetFlagTopic { get; set; }

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

    public int? PnetRate { get; set; }

    public double? PnetRb { get; set; }

    public double? PnetRc { get; set; }

    public double? PnetRd { get; set; }

    public double? PnetSaa { get; set; }

    public int? PnetSchema { get; set; }

    public int? PnetSetValuesInterestRate { get; set; }

    public int? PnetTermRanges { get; set; }

    public Guid? PnetOfertaValorIndividualId { get; set; }

    public Guid? PnetInteractionStatus { get; set; }

    public Guid? PnetInteractionSubStatus { get; set; }

    public Guid? PnetOfferValueId { get; set; }

    public Guid? PnetSaleStatus { get; set; }

    public Guid? PnetSaleSubStatus { get; set; }

    public Guid? PnetUserDirectionFor { get; set; }

    public Guid? PnetTeamDirectionFor { get; set; }

    public int? PnetBuyingPropension { get; set; }

    public Guid? PnetBusinessUnit { get; set; }

    public double? PnetPe { get; set; }

    public double? PnetPf { get; set; }

    public Guid? PnetCommercialBackgroundId { get; set; }

    public Guid? PnetLeadId { get; set; }

    public double? PnetPg { get; set; }

    public DateTime? PnetStartBusinessActivity { get; set; }

    public DateTime? PnetFechafin { get; set; }

    public DateTime? PnetFechainicio { get; set; }
}
