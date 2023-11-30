using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class EntityMapBase
{
    public string? TargetEntityName { get; set; }

    public Guid? EntityMapId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? SourceEntityName { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? OrganizationId { get; set; }

    public Guid? ModifiedBy { get; set; }

    public byte[]? VersionNumber { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ComponentState { get; set; }

    public bool? IsManaged { get; set; }

    public Guid? ModifiedOnBehalfBy { get; set; }

    public DateTime? OverwriteTime { get; set; }

    public Guid? EntityMapIdUnique { get; set; }

    public Guid? SupportingSolutionId { get; set; }

    public Guid? SolutionId { get; set; }

    public Guid? CreatedOnBehalfBy { get; set; }
}
