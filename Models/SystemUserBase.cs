using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class SystemUserBase
{
    public Guid? SystemUserId { get; set; }

    public Guid? TerritoryId { get; set; }

    public Guid? OrganizationId { get; set; }

    public Guid? BusinessUnitId { get; set; }

    public Guid? ParentSystemUserId { get; set; }

    public string? FirstName { get; set; }

    public string? Salutation { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? PersonalEmailAddress { get; set; }

    public string? FullName { get; set; }

    public string? NickName { get; set; }

    public string? Title { get; set; }

    public string? InternalEmailAddress { get; set; }

    public string? JobTitle { get; set; }

    public string? MobileAlertEmail { get; set; }

    public int? PreferredEmailCode { get; set; }

    public string? HomePhone { get; set; }

    public string? MobilePhone { get; set; }

    public int? PreferredPhoneCode { get; set; }

    public int? PreferredAddressCode { get; set; }

    public string? PhotoUrl { get; set; }

    public string? DomainName { get; set; }

    public int? PassportLo { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? PassportHi { get; set; }

    public string? DisabledReason { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public string? EmployeeId { get; set; }

    public Guid? ModifiedBy { get; set; }

    public bool? IsDisabled { get; set; }

    public string? GovernmentId { get; set; }

    public byte[]? VersionNumber { get; set; }

    public string? Skills { get; set; }

    public bool? DisplayInServiceViews { get; set; }

    public Guid? CalendarId { get; set; }

    public Guid? ActiveDirectoryGuid { get; set; }

    public bool? SetupUser { get; set; }

    public Guid? SiteId { get; set; }

    public string? WindowsLiveId { get; set; }

    public int? IncomingEmailDeliveryMethod { get; set; }

    public int? OutgoingEmailDeliveryMethod { get; set; }

    public int? ImportSequenceNumber { get; set; }

    public int? AccessMode { get; set; }

    public int? InviteStatusCode { get; set; }

    public bool? IsActiveDirectoryUser { get; set; }

    public DateTime? OverriddenCreatedOn { get; set; }

    public int? UtcconversionTimeZoneCode { get; set; }

    public int? TimeZoneRuleVersionNumber { get; set; }

    public string? YomiFullName { get; set; }

    public string? YomiLastName { get; set; }

    public string? YomiMiddleName { get; set; }

    public string? YomiFirstName { get; set; }

    public Guid? CreatedOnBehalfBy { get; set; }

    public decimal? ExchangeRate { get; set; }

    public bool? IsIntegrationUser { get; set; }

    public Guid? ModifiedOnBehalfBy { get; set; }

    public int? EmailRouterAccessApproval { get; set; }

    public bool? DefaultFiltersPopulated { get; set; }

    public int? Caltype { get; set; }

    public Guid? QueueId { get; set; }

    public Guid? TransactionCurrencyId { get; set; }

    public string? YammerEmailAddress { get; set; }

    public bool? IsSyncWithDirectory { get; set; }

    public Guid? DefaultMailbox { get; set; }

    public Guid? ProcessId { get; set; }

    public int? UserLicenseType { get; set; }

    public bool? IsEmailAddressApprovedByO365admin { get; set; }

    public string? YammerUserId { get; set; }

    public Guid? EntityImageId { get; set; }

    public bool? IsLicensed { get; set; }

    public Guid? StageId { get; set; }

    public Guid? PositionId { get; set; }

    public string? TraversedPath { get; set; }

    public bool? PnetClass1 { get; set; }

    public int? PnetPanelSin { get; set; }

    public int? PnetPreviousCategory { get; set; }

    public bool? PnetTerD { get; set; }

    public bool? PnetAmountUnder { get; set; }

    public string? PnetBpbaexecutiveId { get; set; }

    public bool? PnetMiniTer { get; set; }

    public Guid? PnetRelSignatureId { get; set; }

    public int? PnetWorkPlanRisk { get; set; }

    public bool? PnetWorkPlanRiskYes { get; set; }

    public int? PnetExcecutiveId { get; set; }

    public int? PnetGeneration { get; set; }

    public Guid? PnetSubsidiary { get; set; }

    public Guid? AxxonContacto { get; set; }

    public bool? AxxonEmpleadovip { get; set; }

    public Guid? AxxonAreaId { get; set; }

    public string? PnetFolder { get; set; }

    public Guid? MobileOfflineProfileId { get; set; }

    public string? DefaultOdbFolderName { get; set; }

    public string? SharePointEmailAddress { get; set; }

    public string? ApplicationIdUri { get; set; }

    public Guid? AzureActiveDirectoryObjectId { get; set; }

    public Guid? ApplicationId { get; set; }

    public bool? PnetSpecialamountunder { get; set; }

    public int? PnetLaboralprofile { get; set; }
}
