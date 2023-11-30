using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class BusinessUnitBase
{
    public Guid? BusinessUnitId { get; set; }

    public Guid? OrganizationId { get; set; }

    public Guid? UserGroupId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? DivisionName { get; set; }

    public string? FileAsName { get; set; }

    public string? TickerSymbol { get; set; }

    public string? StockExchange { get; set; }

    public int? Utcoffset { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public double? CreditLimit { get; set; }

    public string? CostCenter { get; set; }

    public string? WebSiteUrl { get; set; }

    public string? FtpSiteUrl { get; set; }

    public string? EmailAddress { get; set; }

    public int? InheritanceMask { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ModifiedBy { get; set; }

    public bool? WorkflowSuspended { get; set; }

    public Guid? ParentBusinessUnitId { get; set; }

    public bool? IsDisabled { get; set; }

    public string? DisabledReason { get; set; }

    public byte[]? VersionNumber { get; set; }

    public string? Picture { get; set; }

    public Guid? CalendarId { get; set; }

    public DateTime? OverriddenCreatedOn { get; set; }

    public int? ImportSequenceNumber { get; set; }

    public decimal? ExchangeRate { get; set; }

    public Guid? ModifiedOnBehalfBy { get; set; }

    public Guid? CreatedOnBehalfBy { get; set; }

    public Guid? TransactionCurrencyId { get; set; }
}
