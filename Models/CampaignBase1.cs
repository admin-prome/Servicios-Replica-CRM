using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class CampaignBase1
{
    public int? TypeCode { get; set; }

    public DateTime? ProposedEnd { get; set; }

    public decimal? BudgetedCost { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? PromotionCodeName { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? PriceListId { get; set; }

    public int? StatusCode { get; set; }

    public Guid? CreatedBy { get; set; }

    public bool? IsTemplate { get; set; }

    public Guid? CampaignId { get; set; }

    public DateTime? ActualStart { get; set; }

    public Guid? OwningBusinessUnit { get; set; }

    public decimal? TotalActualCost { get; set; }

    public string? Message { get; set; }

    public Guid? ModifiedBy { get; set; }

    public decimal? ExpectedRevenue { get; set; }

    public byte[]? VersionNumber { get; set; }

    public string? CodeName { get; set; }

    public DateTime? ProposedStart { get; set; }

    public string? Objective { get; set; }

    public DateTime? ActualEnd { get; set; }

    public int? StateCode { get; set; }

    public decimal? OtherCost { get; set; }

    public string? Description { get; set; }

    public decimal? TotalCampaignActivityActualCost { get; set; }

    public int? ExpectedResponse { get; set; }

    public string? Name { get; set; }

    public decimal? ExchangeRate { get; set; }

    public int? TimeZoneRuleVersionNumber { get; set; }

    public Guid? TransactionCurrencyId { get; set; }

    public int? ImportSequenceNumber { get; set; }

    public DateTime? OverriddenCreatedOn { get; set; }

    public int? UtcconversionTimeZoneCode { get; set; }

    public decimal? TotalCampaignActivityActualCostBase { get; set; }

    public decimal? BudgetedCostBase { get; set; }

    public decimal? ExpectedRevenueBase { get; set; }

    public decimal? OtherCostBase { get; set; }

    public decimal? TotalActualCostBase { get; set; }

    public Guid? OwnerId { get; set; }

    public Guid? ModifiedOnBehalfBy { get; set; }

    public Guid? CreatedOnBehalfBy { get; set; }

    public int? OwnerIdType { get; set; }

    public Guid? StageId { get; set; }

    public Guid? ProcessId { get; set; }

    public Guid? EntityImageId { get; set; }

    public string? TraversedPath { get; set; }

    public string? PnetCodigoCampania { get; set; }

    public int? PnetCustomerType { get; set; }

    public int? PnetFormType { get; set; }

    public int? PnetInterestRate { get; set; }

    public bool? PnetRequireRate { get; set; }

    public bool? PnetRequireSiteVisit { get; set; }

    public int? PnetRequireWfcolegiatura { get; set; }

    public int? PnetNumberMembers { get; set; }

    public DateTime? PnetNumberMembersDate { get; set; }

    public int? PnetNumberMembersState { get; set; }

    public Guid? PnetCounterId { get; set; }

    public Guid? PnetCreditType { get; set; }

    public Guid? PnetRelatedProduct { get; set; }

    public int? PnetCampaignCode { get; set; }

    public int? PnetXVencimientoCampaginresponse { get; set; }

    public int? PnetXVencimientoOffervalue { get; set; }

    public int? PnetConvenio { get; set; }
}
