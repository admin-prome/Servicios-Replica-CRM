using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PnetListmembersBase
{
    public Guid? PnetListmembersId { get; set; }

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

    public double? PnetCreditAmount { get; set; }

    public int? PnetCreditSubType { get; set; }

    public double? PnetQuotaValue { get; set; }

    public Guid? PnetBusinessUnit { get; set; }

    public Guid? PnetCampaignId { get; set; }

    public Guid? PnetCustomerId { get; set; }

    public Guid? PnetOfferValueId { get; set; }

    public Guid? PnetSegmentId { get; set; }

    public Guid? PnetTeam { get; set; }

    public int? PnetBuyingPropensity { get; set; }

    public int? PnetDocumentNumber { get; set; }

    public int? PnetDocumentType { get; set; }

    public Guid? PnetLeadId { get; set; }

    public DateTime? PnetFechafin { get; set; }

    public DateTime? PnetFechainicio { get; set; }
}
