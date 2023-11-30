using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class TerritoryBase
{
    public Guid? TerritoryId { get; set; }

    public Guid? OrganizationId { get; set; }

    public Guid? ManagerId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public byte[]? VersionNumber { get; set; }

    public int? ImportSequenceNumber { get; set; }

    public DateTime? OverriddenCreatedOn { get; set; }

    public Guid? TransactionCurrencyId { get; set; }

    public Guid? ModifiedOnBehalfBy { get; set; }

    public Guid? CreatedOnBehalfBy { get; set; }

    public decimal? ExchangeRate { get; set; }

    public Guid? EntityImageId { get; set; }
}
