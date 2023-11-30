using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PnetAccountbpba
{
    public string? PnetContactIdName { get; set; }

    public string? PnetContactIdYomiName { get; set; }

    public string? PnetProductTypeIdName { get; set; }

    public string? CreatedOnBehalfByName { get; set; }

    public string? CreatedOnBehalfByYomiName { get; set; }

    public string? ModifiedOnBehalfByName { get; set; }

    public string? ModifiedOnBehalfByYomiName { get; set; }

    public string? ModifiedByName { get; set; }

    public string? ModifiedByYomiName { get; set; }

    public string? CreatedByName { get; set; }

    public string? CreatedByYomiName { get; set; }

    public string? OrganizationIdName { get; set; }

    public Guid? PnetAccountbpbaId { get; set; }

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

    public string? PnetNic { get; set; }

    public string? PnetNip { get; set; }

    public string? PnetSuc { get; set; }

    public string? PnetAccountNumber { get; set; }

    public string? PnetBalanceCa { get; set; }

    public string? PnetCbu { get; set; }

    public string? PnetProductState { get; set; }

    public string? PnetProductStateCode { get; set; }

    public string? PnetProductTypeCode { get; set; }

    public Guid? PnetContactId { get; set; }

    public Guid? PnetProductTypeId { get; set; }
}
