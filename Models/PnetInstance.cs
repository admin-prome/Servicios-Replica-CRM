using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PnetInstance
{
    public string? CreatedByName { get; set; }

    public string? CreatedByYomiName { get; set; }

    public string? CreatedOnBehalfByName { get; set; }

    public string? CreatedOnBehalfByYomiName { get; set; }

    public string? ModifiedByName { get; set; }

    public string? ModifiedByYomiName { get; set; }

    public string? ModifiedOnBehalfByName { get; set; }

    public string? ModifiedOnBehalfByYomiName { get; set; }

    public string? PnetSendByName { get; set; }

    public string? PnetRequestIdName { get; set; }

    public string? PnetSendByYomiName { get; set; }

    public Guid? OwnerId { get; set; }

    public string? OwnerIdName { get; set; }

    public string? OwnerIdYomiName { get; set; }

    public int? OwnerIdDsc { get; set; }

    public int? OwnerIdType { get; set; }

    public Guid? OwningUser { get; set; }

    public Guid? OwningTeam { get; set; }

    public Guid? PnetInstancesId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public Guid? CreatedOnBehalfBy { get; set; }

    public Guid? ModifiedOnBehalfBy { get; set; }

    public Guid? OwningBusinessUnit { get; set; }

    public int? Statecode { get; set; }

    public int? Statuscode { get; set; }

    public byte[]? VersionNumber { get; set; }

    public int? ImportSequenceNumber { get; set; }

    public DateTime? OverriddenCreatedOn { get; set; }

    public int? TimeZoneRuleVersionNumber { get; set; }

    public int? UtcconversionTimeZoneCode { get; set; }

    public string? PnetName { get; set; }

    public string? PnetComment { get; set; }

    public string? PnetPreviousState { get; set; }

    public string? PnetResultState { get; set; }

    public Guid? PnetRequestId { get; set; }

    public string? PnetConsultations { get; set; }

    public string? PnetObservations { get; set; }

    public string? PnetResponse { get; set; }

    public int? PnetAnswers { get; set; }

    public Guid? PnetSendBy { get; set; }

    public bool? PnetAssessImpeccability { get; set; }

    public DateTime? PnetDateProcessed { get; set; }

    public double? PnetCreditAmount { get; set; }

    public double? PnetInterestRate { get; set; }

    public int? PnetQuotasNumber { get; set; }

    public int? PnetRejectedOrigin { get; set; }
}
