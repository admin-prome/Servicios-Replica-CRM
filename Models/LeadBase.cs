using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class LeadBase
{
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

    public bool? IsAutoCreate { get; set; }

    public Guid? ModifiedOnBehalfBy { get; set; }

    public Guid? CreatedOnBehalfBy { get; set; }

    public Guid? OwnerId { get; set; }

    public Guid? CustomerId { get; set; }

    public int? CustomerIdType { get; set; }

    public string? CustomerIdName { get; set; }

    public int? OwnerIdType { get; set; }

    public string? CustomerIdYomiName { get; set; }

    public Guid? StageId { get; set; }

    public bool? DecisionMaker { get; set; }

    public int? Need { get; set; }

    public decimal? BudgetAmount { get; set; }

    public string? QualificationComments { get; set; }

    public Guid? QualifyingOpportunityId { get; set; }

    public DateTime? ScheduleFollowUpQualify { get; set; }

    public bool? ConfirmInterest { get; set; }

    public Guid? ParentAccountId { get; set; }

    public Guid? OriginatingCaseId { get; set; }

    public DateTime? ScheduleFollowUpProspect { get; set; }

    public Guid? EntityImageId { get; set; }

    public Guid? ParentContactId { get; set; }

    public int? InitialCommunication { get; set; }

    public int? SalesStage { get; set; }

    public int? BudgetStatus { get; set; }

    public Guid? ProcessId { get; set; }

    public int? PurchaseTimeFrame { get; set; }

    public int? PurchaseProcess { get; set; }

    public Guid? RelatedObjectId { get; set; }

    public bool? EvaluateFit { get; set; }

    public decimal? BudgetAmountBase { get; set; }

    public string? TraversedPath { get; set; }

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

    public bool? FollowEmail { get; set; }

    public Guid? SlainvokedId { get; set; }

    public string? TimeSpentByMeOnEmailAndMeetings { get; set; }

    public Guid? Slaid { get; set; }

    public int? OnHoldTime { get; set; }

    public DateTime? LastOnHoldTime { get; set; }

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
