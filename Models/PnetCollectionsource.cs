using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PnetCollectionsource
{
    public string? CreatedByName { get; set; }

    public string? CreatedByYomiName { get; set; }

    public string? ModifiedByName { get; set; }

    public string? ModifiedByYomiName { get; set; }

    public string? OrganizationIdName { get; set; }

    public string? PnetPrincipalContactIdYomiName { get; set; }

    public string? PnetPrincipalContactIdName { get; set; }

    public string? PnetContactNameYomiName { get; set; }

    public string? PnetContactNameName { get; set; }

    public string? PnetRelationshipRoleName { get; set; }

    public string? CreatedOnBehalfByName { get; set; }

    public string? CreatedOnBehalfByYomiName { get; set; }

    public string? ModifiedOnBehalfByName { get; set; }

    public string? ModifiedOnBehalfByYomiName { get; set; }

    public Guid? PnetCollectionsourcesId { get; set; }

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

    public string? PnetAddress { get; set; }

    public string? PnetComments { get; set; }

    public bool? PnetFamily { get; set; }

    public string? PnetFullName { get; set; }

    public string? PnetMobilePhone { get; set; }

    public string? PnetPhone { get; set; }

    public int? PnetRelationship { get; set; }

    public Guid? PnetPrincipalContactId { get; set; }

    public string? PnetAreaCode1 { get; set; }

    public string? PnetAreaCode2 { get; set; }

    public string? PnetConsolidateMobilePhone { get; set; }

    public string? PnetConsolidatePhone { get; set; }

    public bool? PnetConnection { get; set; }

    public Guid? PnetContactName { get; set; }

    public Guid? PnetRelationshipRole { get; set; }
}
