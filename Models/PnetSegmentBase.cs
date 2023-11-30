using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PnetSegmentBase
{
    public Guid? PnetSegmentId { get; set; }

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

    public string? PnetActivity { get; set; }

    public string? PnetCategory { get; set; }

    public int? PnetTypifiedSegment { get; set; }

    public int? PnetActivityIcode { get; set; }

    public int? PnetGrupodeactividadme { get; set; }
}
