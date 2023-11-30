using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class ListBase
{
    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? MemberCount { get; set; }

    public string? ListName { get; set; }

    public DateTime? LastUsedOn { get; set; }

    public Guid? ListId { get; set; }

    public int? StateCode { get; set; }

    public int? StatusCode { get; set; }

    public Guid? OwningBusinessUnit { get; set; }

    public Guid? ModifiedBy { get; set; }

    public bool? DoNotSendOnOptOut { get; set; }

    public string? Description { get; set; }

    public string? Purpose { get; set; }

    public decimal? Cost { get; set; }

    public bool? IgnoreInactiveListMembers { get; set; }

    public int? MemberType { get; set; }

    public string? Source { get; set; }

    public int? CreatedFromCode { get; set; }

    public byte[]? VersionNumber { get; set; }

    public bool? LockStatus { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? TransactionCurrencyId { get; set; }

    public int? ImportSequenceNumber { get; set; }

    public int? TimeZoneRuleVersionNumber { get; set; }

    public int? UtcconversionTimeZoneCode { get; set; }

    public decimal? ExchangeRate { get; set; }

    public DateTime? OverriddenCreatedOn { get; set; }

    public decimal? CostBase { get; set; }

    public Guid? CreatedOnBehalfBy { get; set; }

    public bool? Type { get; set; }

    public string? Query { get; set; }

    public Guid? ModifiedOnBehalfBy { get; set; }

    public Guid? OwnerId { get; set; }

    public int? OwnerIdType { get; set; }

    public Guid? StageId { get; set; }

    public Guid? ProcessId { get; set; }

    public string? TraversedPath { get; set; }

    public Guid? PnetContactoId { get; set; }

    public Guid? PnetTopic { get; set; }

    public string? PnetCode { get; set; }

    public double? PnetCreditAmount { get; set; }

    public int? PnetCreditSubType { get; set; }

    public double? PnetQuotaAmount { get; set; }

    public Guid? PnetBusinessUnit { get; set; }

    public Guid? PnetCampaniaId { get; set; }

    public Guid? PnetCounterId { get; set; }

    public Guid? PnetSegmentId { get; set; }

    public Guid? PnetTeam { get; set; }

    public int? PnetBuyingPropensity { get; set; }

    public int? PnetCounterValue { get; set; }

    public DateTime? PnetFechafin { get; set; }

    public DateTime? PnetFechainicio { get; set; }
}
