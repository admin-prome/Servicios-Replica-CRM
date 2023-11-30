using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PnetDistrictLocalityBase
{
    public Guid? PnetDistrictLocalityId { get; set; }

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

    public string? PnetDistrict { get; set; }

    public int? PnetNumberZone { get; set; }

    public string? PnetZone { get; set; }

    public Guid? PnetSubsidiaryId { get; set; }

    public int? PnetProvince { get; set; }

    public string? PnetCode { get; set; }
}
