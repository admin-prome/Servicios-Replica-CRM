using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PositionBase
{
    public Guid? CreatedBy { get; set; }

    public Guid? ParentPositionId { get; set; }

    public string? Name { get; set; }

    public int? ImportSequenceNumber { get; set; }

    public Guid? CreatedOnBehalfBy { get; set; }

    public Guid? ModifiedOnBehalfBy { get; set; }

    public DateTime? OverriddenCreatedOn { get; set; }

    public int? UtcconversionTimeZoneCode { get; set; }

    public int? Statecode { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? StatusCode { get; set; }

    public int? TimeZoneRuleVersionNumber { get; set; }

    public string? Description { get; set; }

    public decimal? ExchangeRate { get; set; }

    public Guid? TransactionCurrencyId { get; set; }

    public Guid? OrganizationId { get; set; }

    public Guid? ModifiedBy { get; set; }

    public Guid? PositionId { get; set; }

    public byte[]? VersionNumber { get; set; }
}
