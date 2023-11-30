﻿using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PnetSalesubstatusBase
{
    public Guid? PnetSalesubstatusId { get; set; }

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

    public Guid? PnetSaleStatus { get; set; }

    public bool? PnetCampaignResponse { get; set; }

    public Guid? PnetInteractionSubStatusId { get; set; }

    public bool? PnetPhoneCall { get; set; }
}
