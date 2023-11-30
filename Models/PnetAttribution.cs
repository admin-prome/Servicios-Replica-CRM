using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PnetAttribution
{
    public string? ModifiedOnBehalfByName { get; set; }

    public string? ModifiedOnBehalfByYomiName { get; set; }

    public string? OrganizationIdName { get; set; }

    public string? CreatedOnBehalfByName { get; set; }

    public string? CreatedOnBehalfByYomiName { get; set; }

    public string? PnetUserIdName { get; set; }

    public string? PnetUserIdYomiName { get; set; }

    public string? ModifiedByName { get; set; }

    public string? ModifiedByYomiName { get; set; }

    public string? CreatedByName { get; set; }

    public string? CreatedByYomiName { get; set; }

    public Guid? PnetAttributionsId { get; set; }

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

    public bool? PnetAmountRenewal { get; set; }

    public bool? PnetAmountUnder { get; set; }

    public bool? PnetClass1 { get; set; }

    public int? PnetCurrentCategory { get; set; }

    public double? PnetExcellentFactorCorrection { get; set; }

    public int? PnetExceptionLevel { get; set; }

    public double? PnetGoodFactorCorrection { get; set; }

    public bool? PnetMiniTer { get; set; }

    public int? PnetMonthPeriod { get; set; }

    public bool? PnetNoExceptionPayFees { get; set; }

    public double? PnetNote { get; set; }

    public int? PnetPanel { get; set; }

    public int? PnetPanelSin { get; set; }

    public int? PnetPreviousCategory { get; set; }

    public int? PnetPreviousCategory2 { get; set; }

    public double? PnetRegularFactorCorrection { get; set; }

    public bool? PnetSimpleMiniter { get; set; }

    public bool? PnetTerD { get; set; }

    public bool? PnetTotalSuspensionAttributions { get; set; }

    public int? PnetWorkPlanRisk { get; set; }

    public int? PnetYearPeriod { get; set; }

    public Guid? PnetUserId { get; set; }

    public bool? PnetProfileCollection { get; set; }

    public bool? PnetWorkPlanRiskYes { get; set; }

    public bool? PnetSpecialamountunder { get; set; }

    public bool? PnetAtribMm25smvm { get; set; }
}
