using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PnetPortfoliorecordBase
{
    public Guid? PnetPortfoliorecordId { get; set; }

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

    public DateTime? PnetProcessdate { get; set; }

    public string? PnetHoldername { get; set; }

    public string? PnetDocumenttype { get; set; }

    public string? PnetDocumentnumber { get; set; }

    public string? PnetNif { get; set; }

    public string? PnetPhonenumber { get; set; }

    public decimal? PnetBalance { get; set; }

    public DateTime? PnetLastmovementdate { get; set; }

    public DateTime? PnetGrantdate { get; set; }

    public int? PnetPayments { get; set; }

    public decimal? PnetPaymentamount { get; set; }

    public decimal? PnetClaimabledebt { get; set; }

    public decimal? PnetHedgeddebt { get; set; }

    public DateTime? PnetNextsettlementdate { get; set; }

    public decimal? PnetReconciledbalance { get; set; }

    public DateTime? PnetMinimalduedate { get; set; }

    public decimal? PnetDebtexpirationbalance { get; set; }

    public decimal? PnetMinimalexpirationamount { get; set; }

    public decimal? PnetPaymentsaccumulationamount { get; set; }

    public DateTime? PnetNextexpirationdate { get; set; }

    public int? PnetContract { get; set; }

    public int? PnetPerson { get; set; }

    public int? PnetAddress { get; set; }

    public string? PnetClexaccount { get; set; }

    public int? PnetBranch { get; set; }

    public string? PnetAccounttype { get; set; }

    public int? PnetAccountnumber { get; set; }

    public int? PnetCnae { get; set; }

    public string? PnetNacionality { get; set; }

    public int? PnetSit { get; set; }

    public DateTime? PnetOpeningdate { get; set; }

    public DateTime? PnetExpirationdate { get; set; }

    public string? PnetAccount { get; set; }

    public int? PnetCommitmentDate { get; set; }

    public string? PnetEmailAddress { get; set; }

    public string? PnetHeadquarterCode { get; set; }

    public string? PnetOpportunityNumber { get; set; }

    public Guid? PnetOpportunityId { get; set; }

    public Guid? PnetCreditId { get; set; }

    public Guid? PnetCommercialExecutiveAdminId { get; set; }

    public Guid? PnetCommercialExecutiveId { get; set; }

    public Guid? PnetZoneId { get; set; }

    public DateTime? PnetPaymentDate { get; set; }

    public int? PnetBpbasubsidiary { get; set; }

    public decimal? PnetCardAccumulatedPayments { get; set; }

    public decimal? PnetCardDebtBalance { get; set; }

    public DateTime? PnetCardExpirationDate { get; set; }

    public decimal? PnetCardMinimumAmount { get; set; }

    public Guid? PnetComercialExecutiveAssignedId { get; set; }

    public int? PnetCommitmentDay { get; set; }

    public Guid? PnetContactId { get; set; }

    public string? PnetCreditSubtype { get; set; }

    public string? PnetCreditType { get; set; }

    public decimal? PnetDebtCover { get; set; }

    public int? PnetDelayDays { get; set; }

    public decimal? PnetGrantedAmount { get; set; }

    public decimal? PnetLoanBalance { get; set; }

    public DateTime? PnetNextLiquidationDate { get; set; }

    public int? PnetPromesubsidiary { get; set; }

    public decimal? PnetRate { get; set; }

    public string? PnetSubsidiaryName { get; set; }

    public int? PnetTerm { get; set; }

    public string? PnetZone { get; set; }

    public string? PnetComercialexecutiveassignedtext { get; set; }
}
