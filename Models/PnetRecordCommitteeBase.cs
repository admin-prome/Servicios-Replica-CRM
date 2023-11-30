using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PnetRecordCommitteeBase
{
    public Guid? PnetRecordCommitteeId { get; set; }

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

    public bool? PnetAccountRequested { get; set; }

    public bool? PnetBail { get; set; }

    public bool? PnetBusinessBackground { get; set; }

    public DateTime? PnetCancelationDate { get; set; }

    public string? PnetComment { get; set; }

    public bool? PnetComplianceScore { get; set; }

    public double? PnetCreditAmount { get; set; }

    public double? PnetCreditCardLimit { get; set; }

    public int? PnetCreditDescription { get; set; }

    public bool? PnetCreditFile { get; set; }

    public string? PnetCreditNumber { get; set; }

    public int? PnetCreditProductDescription { get; set; }

    public int? PnetCreditType { get; set; }

    public DateTime? PnetFirstPaymentDate { get; set; }

    public bool? PnetNotificationUnfavorableBackground { get; set; }

    public bool? PnetOtherCredit { get; set; }

    public bool? PnetPreferentialRate { get; set; }

    public int? PnetQuotasNumber { get; set; }

    public string? PnetSavingAccountNumber { get; set; }

    public Guid? PnetContactId { get; set; }

    public Guid? PnetOpportunityId { get; set; }

    public Guid? PnetExecutiveId { get; set; }

    public Guid? PnetCounterId { get; set; }

    public int? PnetAv { get; set; }

    public int? PnetCsr { get; set; }

    public int? PnetCvub { get; set; }

    public int? PnetNub { get; set; }

    public int? PnetVcf { get; set; }

    public int? PnetVof { get; set; }

    public string? PnetAddress { get; set; }

    public int? PnetAddressNumber { get; set; }

    public string? PnetBetweenStreets { get; set; }

    public string? PnetBlock { get; set; }

    public string? PnetBody { get; set; }

    public string? PnetCorner { get; set; }

    public string? PnetDepartment { get; set; }

    public string? PnetExtraDetails { get; set; }

    public string? PnetFloor { get; set; }

    public string? PnetLocal { get; set; }

    public string? PnetLot { get; set; }

    public string? PnetNeighborhood { get; set; }

    public string? PnetPostalCode { get; set; }

    public string? PnetSavingAccountsInformation { get; set; }

    public string? PnetTower { get; set; }

    public Guid? PnetDistrictLocalityId { get; set; }
}
