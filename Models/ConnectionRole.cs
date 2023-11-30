using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class ConnectionRole
{
    public string? CreatedByYomiName { get; set; }

    public string? CreatedByName { get; set; }

    public string? ModifiedOnBehalfByYomiName { get; set; }

    public string? ModifiedOnBehalfByName { get; set; }

    public string? CreatedOnBehalfByYomiName { get; set; }

    public string? CreatedOnBehalfByName { get; set; }

    public string? OrganizationIdName { get; set; }

    public string? ModifiedByName { get; set; }

    public string? ModifiedByYomiName { get; set; }

    public Guid? ConnectionRoleId { get; set; }

    public Guid? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? Name { get; set; }

    public int? ImportSequenceNumber { get; set; }

    public int? StateCode { get; set; }

    public int? StatusCode { get; set; }

    public Guid? CreatedBy { get; set; }

    public int? Category { get; set; }

    public Guid? OrganizationId { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedOn { get; set; }

    public byte[]? VersionNumber { get; set; }

    public Guid? SolutionId { get; set; }

    public Guid? SupportingSolutionId { get; set; }

    public int? ComponentState { get; set; }

    public DateTime? OverwriteTime { get; set; }

    public Guid? ConnectionRoleIdUnique { get; set; }

    public Guid? ModifiedOnBehalfBy { get; set; }

    public Guid? CreatedOnBehalfBy { get; set; }

    public bool? IsManaged { get; set; }

    public bool? IsCustomizable { get; set; }

    public string? IntroducedVersion { get; set; }
}
