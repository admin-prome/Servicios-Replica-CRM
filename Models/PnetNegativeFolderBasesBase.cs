using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PnetNegativeFolderBasesBase
{
    public Guid? PnetNegativeFolderBasesId { get; set; }

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

    public bool? PnetPreInitialInterviewComplete { get; set; }

    public int? PnetStatus { get; set; }

    public Guid? PnetPrincipalContactId { get; set; }

    public Guid? PnetPhoneCallId { get; set; }

    public Guid? PnetCounterId { get; set; }

    public Guid? PnetSubsidiaryId { get; set; }

    public bool? PnetAcmanagement { get; set; }

    public bool? PnetCallCenterManagement { get; set; }

    public double? PnetEstimatedamount { get; set; }

    public string? PnetFateCredit { get; set; }

    public int? PnetFee { get; set; }

    public Guid? PnetExecutiveResponsibleId { get; set; }

    public int? PnetAmountTaxes { get; set; }

    public bool? PnetClass1 { get; set; }

    public int? PnetClassification { get; set; }

    public string? PnetComments { get; set; }

    public int? PnetEmployeeMonthlySalary { get; set; }

    public int? PnetFamilyHelp { get; set; }

    public bool? PnetHasEmployees { get; set; }

    public bool? PnetHaveaccountwithotherBank { get; set; }

    public bool? PnetHaveCreditCard { get; set; }

    public bool? PnetHaveCredits { get; set; }

    public bool? PnetHaveinsurance { get; set; }

    public bool? PnetHaveProductsBp { get; set; }

    public int? PnetHowManyEmployees { get; set; }

    public bool? PnetIsMonotributista { get; set; }

    public bool? PnetIsRi { get; set; }

    public bool? PnetIsStoreOwner { get; set; }

    public bool? PnetItjpg1 { get; set; }

    public bool? PnetItjpg2 { get; set; }

    public bool? PnetItjpg3 { get; set; }

    public string? PnetMenameContact { get; set; }

    public int? PnetMonthlyRent { get; set; }

    public int? PnetMonthlySales { get; set; }

    public bool? PnetMtjpg1 { get; set; }

    public bool? PnetMtjpg2 { get; set; }

    public bool? PnetMtsjpg1 { get; set; }

    public string? PnetNfprincipalApplication { get; set; }

    public bool? PnetOtherIncome { get; set; }

    public int? PnetPanelSin { get; set; }

    public int? PnetPreviousCategory { get; set; }

    public int? PnetProductType { get; set; }

    public bool? PnetReport { get; set; }

    public int? PnetTypeofBank { get; set; }

    public string? PnetTypeofCredit { get; set; }

    public int? PnetTypeofCreditCard { get; set; }

    public string? PnetTypeofInsurance { get; set; }

    public string? PnetTypeofProductsBp { get; set; }

    public string? PnetUrlreportEi { get; set; }

    public string? PnetUrltemplate { get; set; }

    public Guid? PnetMename { get; set; }

    public Guid? PnetCommercialBackground { get; set; }

    public string? PnetComments2 { get; set; }

    public int? PnetCompletePd { get; set; }

    public bool? PnetCompletePersonalData { get; set; }
}
