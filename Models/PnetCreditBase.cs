using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PnetCreditBase
{
    public Guid? PnetCreditId { get; set; }

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

    public int? PnetCommitmentDate { get; set; }

    public string? PnetHeadquarterCode { get; set; }

    public string? PnetNif { get; set; }

    public string? PnetOpportunityNumber { get; set; }

    public Guid? PnetOpportunityId { get; set; }

    public Guid? PnetCommercialExecutiveAdminId { get; set; }

    public Guid? PnetCommercialExecutiveId { get; set; }

    public Guid? PnetZoneId { get; set; }

    public bool? PnetAccepted { get; set; }

    public Guid? PnetAssignedExecutiveId { get; set; }

    public string? PnetAssignedExecutiveText { get; set; }

    public bool? PnetOverdue { get; set; }

    public int? PnetState { get; set; }

    public Guid? PnetContactId { get; set; }
}
