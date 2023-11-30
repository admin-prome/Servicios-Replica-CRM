using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class Lead
{
    public string? PnetDistrictLocalityIdName { get; set; }

    public string? CampaignIdName { get; set; }

    public string? ModifiedOnBehalfByName { get; set; }

    public string? ModifiedOnBehalfByYomiName { get; set; }

    public string? PnetSubsidiaryIdName { get; set; }

    public string? PnetSubsidiaryIdYomiName { get; set; }

    public string? TransactionCurrencyIdName { get; set; }

    public string? PnetCnaeidName { get; set; }

    public string? PnetRecommendedByIdName { get; set; }

    public string? PnetRecommendedByIdYomiName { get; set; }

    public string? MasterLeadIdName { get; set; }

    public string? MasterLeadIdYomiName { get; set; }

    public string? ParentAccountIdYomiName { get; set; }

    public string? ParentAccountIdName { get; set; }

    public string? SlainvokedIdName { get; set; }

    public string? PnetCnoidName { get; set; }

    public string? OriginatingCaseIdName { get; set; }

    public string? ModifiedByName { get; set; }

    public string? ModifiedByYomiName { get; set; }

    public string? QualifyingOpportunityIdName { get; set; }

    public string? CreatedOnBehalfByName { get; set; }

    public string? CreatedOnBehalfByYomiName { get; set; }

    public string? RelatedObjectIdName { get; set; }

    public string? CreatedByYomiName { get; set; }

    public string? CreatedByName { get; set; }

    public byte[]? EntityImage { get; set; }

    public long? EntityImageTimestamp { get; set; }

    public string? EntityImageUrl { get; set; }

    public string? Slaname { get; set; }

    public string? PnetSegmentIdName { get; set; }

    public string? ParentContactIdYomiName { get; set; }

    public string? ParentContactIdName { get; set; }

    public int? Address1AddressTypeCode { get; set; }

    public string? Address1City { get; set; }

    public string? Address1Composite { get; set; }

    public string? Address1Country { get; set; }

    public string? Address1County { get; set; }

    public string? Address1Fax { get; set; }

    public double? Address1Latitude { get; set; }

    public Guid? Address1AddressId { get; set; }

    public string? Address1Line1 { get; set; }

    public string? Address1Line2 { get; set; }

    public string? Address1Line3 { get; set; }

    public double? Address1Longitude { get; set; }

    public string? Address1Name { get; set; }

    public string? Address1PostalCode { get; set; }

    public string? Address1PostOfficeBox { get; set; }

    public int? Address1ShippingMethodCode { get; set; }

    public string? Address1StateOrProvince { get; set; }

    public string? Address1Telephone1 { get; set; }

    public string? Address1Telephone2 { get; set; }

    public string? Address1Telephone3 { get; set; }

    public string? Address1Upszone { get; set; }

    public int? Address1Utcoffset { get; set; }

    public int? Address2AddressTypeCode { get; set; }

    public string? Address2City { get; set; }

    public string? Address2Composite { get; set; }

    public string? Address2Country { get; set; }

    public string? Address2County { get; set; }

    public string? Address2Fax { get; set; }

    public double? Address2Latitude { get; set; }

    public Guid? Address2AddressId { get; set; }

    public string? Address2Line1 { get; set; }

    public string? Address2Line2 { get; set; }

    public string? Address2Line3 { get; set; }

    public double? Address2Longitude { get; set; }

    public string? Address2Name { get; set; }

    public string? Address2PostalCode { get; set; }

    public string? Address2PostOfficeBox { get; set; }

    public int? Address2ShippingMethodCode { get; set; }

    public string? Address2StateOrProvince { get; set; }

    public string? Address2Telephone1 { get; set; }

    public string? Address2Telephone2 { get; set; }

    public string? Address2Telephone3 { get; set; }

    public string? Address2Upszone { get; set; }

    public int? Address2Utcoffset { get; set; }

    public Guid? OwnerId { get; set; }

    public string? OwnerIdName { get; set; }

    public string? OwnerIdYomiName { get; set; }

    public int? OwnerIdDsc { get; set; }

    public int? OwnerIdType { get; set; }

    public Guid? OwningUser { get; set; }

    public Guid? OwningTeam { get; set; }

    public Guid? AccountId { get; set; }

    public string? AccountIdName { get; set; }

    public string? AccountIdYomiName { get; set; }

    public Guid? ContactId { get; set; }

    public string? ContactIdName { get; set; }

    public string? ContactIdYomiName { get; set; }

    public Guid? LeadId { get; set; }

    public int? LeadSourceCode { get; set; }

    public int? LeadQualityCode { get; set; }

    public int? PriorityCode { get; set; }

    public int? IndustryCode { get; set; }

    public int? PreferredContactMethodCode { get; set; }

    public int? SalesStageCode { get; set; }

    public Guid? OwningBusinessUnit { get; set; }

    public string? Subject { get; set; }

    public bool? ParticipatesInWorkflow { get; set; }

    public string? Description { get; set; }

    public double? EstimatedValue { get; set; }

    public DateTime? EstimatedCloseDate { get; set; }

    public string? CompanyName { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public decimal? Revenue { get; set; }

    public int? NumberOfEmployees { get; set; }

    public bool? DoNotPhone { get; set; }

    public string? Sic { get; set; }

    public bool? DoNotFax { get; set; }

    public string? EmailAddress1 { get; set; }

    public string? JobTitle { get; set; }

    public string? Salutation { get; set; }

    public bool? DoNotEmail { get; set; }

    public string? EmailAddress2 { get; set; }

    public bool? DoNotPostalMail { get; set; }

    public string? EmailAddress3 { get; set; }

    public string? FullName { get; set; }

    public string? YomiFirstName { get; set; }

    public string? WebSiteUrl { get; set; }

    public string? Telephone1 { get; set; }

    public string? Telephone2 { get; set; }

    public string? Telephone3 { get; set; }

    public DateTime? CreatedOn { get; set; }

    public bool? IsPrivate { get; set; }

    public string? Fax { get; set; }

    public string? YomiMiddleName { get; set; }

    public string? YomiLastName { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public string? YomiFullName { get; set; }

    public string? MobilePhone { get; set; }

    public int? StateCode { get; set; }

    public string? Pager { get; set; }

    public int? StatusCode { get; set; }

    public byte[]? VersionNumber { get; set; }

    public Guid? CustomerId { get; set; }

    public string? CustomerIdName { get; set; }

    public int? CustomerIdType { get; set; }

    public Guid? MasterId { get; set; }

    public Guid? CampaignId { get; set; }

    public bool? DoNotSendMm { get; set; }

    public bool? Merged { get; set; }

    public bool? DoNotBulkEmail { get; set; }

    public DateTime? LastUsedInCampaign { get; set; }

    public Guid? TransactionCurrencyId { get; set; }

    public int? TimeZoneRuleVersionNumber { get; set; }

    public int? UtcconversionTimeZoneCode { get; set; }

    public int? ImportSequenceNumber { get; set; }

    public DateTime? OverriddenCreatedOn { get; set; }

    public decimal? ExchangeRate { get; set; }

    public decimal? EstimatedAmount { get; set; }

    public decimal? EstimatedAmountBase { get; set; }

    public decimal? RevenueBase { get; set; }

    public string? YomiCompanyName { get; set; }

    public string? CustomerIdYomiName { get; set; }

    public Guid? CreatedOnBehalfBy { get; set; }

    public Guid? ModifiedOnBehalfBy { get; set; }

    public bool? IsAutoCreate { get; set; }

    public Guid? ParentAccountId { get; set; }

    public Guid? ParentContactId { get; set; }

    public Guid? RelatedObjectId { get; set; }

    public decimal? BudgetAmount { get; set; }

    public decimal? BudgetAmountBase { get; set; }

    public int? BudgetStatus { get; set; }

    public bool? DecisionMaker { get; set; }

    public int? Need { get; set; }

    public int? PurchaseTimeFrame { get; set; }

    public string? TraversedPath { get; set; }

    public bool? EvaluateFit { get; set; }

    public int? InitialCommunication { get; set; }

    public bool? ConfirmInterest { get; set; }

    public int? PurchaseProcess { get; set; }

    public int? SalesStage { get; set; }

    public DateTime? ScheduleFollowUpProspect { get; set; }

    public DateTime? ScheduleFollowUpQualify { get; set; }

    public string? QualificationComments { get; set; }

    public Guid? QualifyingOpportunityId { get; set; }

    public Guid? StageId { get; set; }

    public Guid? ProcessId { get; set; }

    public Guid? EntityImageId { get; set; }

    public Guid? OriginatingCaseId { get; set; }

    public Guid? Slaid { get; set; }

    public Guid? SlainvokedId { get; set; }

    public int? OnHoldTime { get; set; }

    public DateTime? LastOnHoldTime { get; set; }

    public bool? FollowEmail { get; set; }

    public string? TimeSpentByMeOnEmailAndMeetings { get; set; }

    public string? PnetAddress { get; set; }

    public int? PnetAddressNumber { get; set; }

    public Guid? PnetRecommendedById { get; set; }

    public Guid? PnetDistrictLocalityId { get; set; }

    public Guid? PnetSubsidiaryId { get; set; }

    public string? PnetAreaCode1 { get; set; }

    public string? PnetAreaCode2 { get; set; }

    public string? PnetAreaCode3 { get; set; }

    public string? PnetConsolidatePhone1 { get; set; }

    public string? PnetConsolidatePhone2 { get; set; }

    public string? PnetConsolidatePhone3 { get; set; }

    public string? PnetPhone1 { get; set; }

    public string? PnetPhone2 { get; set; }

    public string? PnetPhone3 { get; set; }

    public int? PnetPhoneType1 { get; set; }

    public int? PnetPhoneType2 { get; set; }

    public int? PnetPhoneType3 { get; set; }

    public string? PnetAccountName { get; set; }

    public string? PnetBlock { get; set; }

    public Guid? PnetCnaeid { get; set; }

    public Guid? PnetCnoid { get; set; }

    public bool? PnetCommercialAction { get; set; }

    public string? PnetCommercialActionDescription { get; set; }

    public string? PnetDepartment { get; set; }

    public int? PnetDocumentNumber { get; set; }

    public int? PnetDocumentType { get; set; }

    public string? PnetDoor { get; set; }

    public bool? PnetDuplicatedContact { get; set; }

    public string? PnetFloor { get; set; }

    public int? PnetGender { get; set; }

    public string? PnetNeighborhood { get; set; }

    public int? PnetPermanency { get; set; }

    public Guid? PnetSegmentId { get; set; }

    public DateTime? PnetStartBusinessActivity { get; set; }

    public double? PnetTaxdocumentnumber { get; set; }

    public double? PnetTaxdocumentnumber2 { get; set; }

    public double? PnetTaxdocumentnumber3 { get; set; }

    public int? PnetTaxdocumenttype { get; set; }

    public DateTime? PnetGetServerDate { get; set; }
}
