using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class OpportunityBase1
{
    public Guid? OpportunityId { get; set; }

    public Guid? PriceLevelId { get; set; }

    public int? OpportunityRatingCode { get; set; }

    public int? PriorityCode { get; set; }

    public string? Name { get; set; }

    public Guid? StepId { get; set; }

    public string? Description { get; set; }

    public decimal? EstimatedValue { get; set; }

    public string? StepName { get; set; }

    public int? SalesStageCode { get; set; }

    public bool? ParticipatesInWorkflow { get; set; }

    public int? PricingErrorCode { get; set; }

    public DateTime? EstimatedCloseDate { get; set; }

    public int? CloseProbability { get; set; }

    public decimal? ActualValue { get; set; }

    public DateTime? ActualCloseDate { get; set; }

    public Guid? OwningBusinessUnit { get; set; }

    public Guid? OriginatingLeadId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public bool? IsPrivate { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public byte[]? VersionNumber { get; set; }

    public int? StateCode { get; set; }

    public int? StatusCode { get; set; }

    public bool? IsRevenueSystemCalculated { get; set; }

    public Guid? CampaignId { get; set; }

    public Guid? TransactionCurrencyId { get; set; }

    public decimal? ExchangeRate { get; set; }

    public int? ImportSequenceNumber { get; set; }

    public int? UtcconversionTimeZoneCode { get; set; }

    public int? TimeZoneRuleVersionNumber { get; set; }

    public DateTime? OverriddenCreatedOn { get; set; }

    public decimal? ActualValueBase { get; set; }

    public decimal? EstimatedValueBase { get; set; }

    public decimal? TotalDiscountAmount { get; set; }

    public Guid? ModifiedOnBehalfBy { get; set; }

    public decimal? TotalAmount { get; set; }

    public Guid? CreatedOnBehalfBy { get; set; }

    public decimal? TotalAmountLessFreight { get; set; }

    public decimal? TotalLineItemDiscountAmount { get; set; }

    public Guid? CustomerId { get; set; }

    public decimal? DiscountAmount { get; set; }

    public Guid? OwnerId { get; set; }

    public decimal? FreightAmount { get; set; }

    public decimal? TotalTax { get; set; }

    public decimal? DiscountPercentage { get; set; }

    public decimal? TotalLineItemAmount { get; set; }

    public string? CustomerIdName { get; set; }

    public int? CustomerIdType { get; set; }

    public int? OwnerIdType { get; set; }

    public decimal? TotalDiscountAmountBase { get; set; }

    public decimal? FreightAmountBase { get; set; }

    public decimal? TotalLineItemAmountBase { get; set; }

    public decimal? TotalTaxBase { get; set; }

    public decimal? TotalLineItemDiscountAmountBase { get; set; }

    public decimal? TotalAmountBase { get; set; }

    public decimal? DiscountAmountBase { get; set; }

    public decimal? TotalAmountLessFreightBase { get; set; }

    public string? CustomerIdYomiName { get; set; }

    public bool? FileDebrief { get; set; }

    public int? BudgetStatus { get; set; }

    public bool? PresentProposal { get; set; }

    public bool? SendThankYouNote { get; set; }

    public bool? EvaluateFit { get; set; }

    public DateTime? FinalDecisionDate { get; set; }

    public bool? ConfirmInterest { get; set; }

    public bool? CompleteInternalReview { get; set; }

    public int? TimeLine { get; set; }

    public string? CustomerPainPoints { get; set; }

    public bool? ResolveFeedback { get; set; }

    public string? QuoteComments { get; set; }

    public int? PurchaseProcess { get; set; }

    public bool? CaptureProposalFeedback { get; set; }

    public Guid? ParentContactId { get; set; }

    public bool? IdentifyCustomerContacts { get; set; }

    public bool? CompleteFinalProposal { get; set; }

    public decimal? BudgetAmount { get; set; }

    public Guid? ParentAccountId { get; set; }

    public DateTime? ScheduleFollowupQualify { get; set; }

    public int? Need { get; set; }

    public bool? PursuitDecision { get; set; }

    public Guid? ProcessId { get; set; }

    public DateTime? ScheduleProposalMeeting { get; set; }

    public Guid? StageId { get; set; }

    public string? QualificationComments { get; set; }

    public int? SalesStage { get; set; }

    public int? InitialCommunication { get; set; }

    public bool? IdentifyPursuitTeam { get; set; }

    public DateTime? ScheduleFollowupProspect { get; set; }

    public int? PurchaseTimeframe { get; set; }

    public bool? IdentifyCompetitors { get; set; }

    public bool? DecisionMaker { get; set; }

    public string? CurrentSituation { get; set; }

    public string? CustomerNeed { get; set; }

    public string? ProposedSolution { get; set; }

    public bool? PresentFinalProposal { get; set; }

    public bool? DevelopProposal { get; set; }

    public decimal? BudgetAmountBase { get; set; }

    public string? TraversedPath { get; set; }

    public double? Pnet30dayPaymentMethod { get; set; }

    public double? PnetAccountsReceivable { get; set; }

    public int? PnetAccumulatorWillPay { get; set; }

    public int? PnetAdultNumber { get; set; }

    public int? PnetApprovalStatusStage1 { get; set; }

    public int? PnetApprovalStatusStage2 { get; set; }

    public int? PnetApprovalStatusStage3 { get; set; }

    public int? PnetApprovalStatusStage4 { get; set; }

    public int? PnetApprovalStatusStage5 { get; set; }

    public int? PnetApril { get; set; }

    public int? PnetAugust { get; set; }

    public int? PnetAverageAgeEmployees { get; set; }

    public double? PnetAverageFee { get; set; }

    public string? PnetBusinessDescription { get; set; }

    public double? PnetCar { get; set; }

    public double? PnetCashbox { get; set; }

    public double? PnetCashPaymentMethod { get; set; }

    public bool? PnetChangeOwnership { get; set; }

    public int? PnetChildrenNumber { get; set; }

    public int? PnetClassificationWillingnessToPay { get; set; }

    public string? PnetCommercializationObservation { get; set; }

    public DateTime? PnetCommunicationDate { get; set; }

    public int? PnetContratationType { get; set; }

    public double? PnetCorrectionFactorDebtMonthHigh { get; set; }

    public double? PnetCorrectionFactorDebtMonthLow { get; set; }

    public double? PnetCorrectionFactorDebtMonthMiddle { get; set; }

    public double? PnetCorrectionFactorMonthHigh { get; set; }

    public double? PnetCorrectionFactorMonthLow { get; set; }

    public double? PnetCorrectionFactorMonthMiddle { get; set; }

    public double? PnetCoursesWorkshops { get; set; }

    public bool? PnetCpadecreased { get; set; }

    public bool? PnetCpaincreased { get; set; }

    public double? PnetCreditAmount { get; set; }

    public string? PnetCreditFate { get; set; }

    public int? PnetCreditSubType { get; set; }

    public int? PnetCreditType { get; set; }

    public double? PnetCustomerMonthHigh { get; set; }

    public double? PnetCustomerMonthLow { get; set; }

    public double? PnetCustomerMonthMiddle { get; set; }

    public int? PnetCustomerType { get; set; }

    public double? PnetCustomerTypeCompany { get; set; }

    public double? PnetCustomerTypeFactorPercent { get; set; }

    public double? PnetCustomerTypeOther { get; set; }

    public double? PnetCustomerTypeParticular { get; set; }

    public double? PnetCv1 { get; set; }

    public double? PnetCv2 { get; set; }

    public double? PnetCv3 { get; set; }

    public double? PnetCvx1 { get; set; }

    public double? PnetCvx2 { get; set; }

    public double? PnetCvx3 { get; set; }

    public double? PnetDebtAdjustedMonthHigh { get; set; }

    public double? PnetDebtAdjustedMonthLow { get; set; }

    public double? PnetDebtAdjustedMonthMiddle { get; set; }

    public double? PnetDebtsMonthHigh { get; set; }

    public double? PnetDebtsMonthLow { get; set; }

    public double? PnetDebtsMonthMiddle { get; set; }

    public double? PnetDebtsToPay { get; set; }

    public int? PnetDecember { get; set; }

    public double? PnetDividends { get; set; }

    public double? PnetDueMoreThanOneYear { get; set; }

    public int? PnetEmployeesNumber { get; set; }

    public int? PnetExceptionLevel { get; set; }

    public bool? PnetExceptionsAmount { get; set; }

    public bool? PnetExceptionsDebt { get; set; }

    public double? PnetExecutiveMonthHigh { get; set; }

    public double? PnetExecutiveMonthLow { get; set; }

    public double? PnetExecutiveMonthMiddle { get; set; }

    public int? PnetExecutiveSeniority { get; set; }

    public double? PnetExtraSchoolActivities { get; set; }

    public double? PnetFamilyExpensesMonthHigh { get; set; }

    public double? PnetFamilyExpensesMonthLow { get; set; }

    public double? PnetFamilyExpensesMonthMiddle { get; set; }

    public string? PnetFamilyGroupObservations { get; set; }

    public bool? PnetFamilyStrength { get; set; }

    public int? PnetFebruary { get; set; }

    public double? PnetFixedCostMonthHigh { get; set; }

    public double? PnetFixedCostMonthLow { get; set; }

    public double? PnetFixedCostMonthMiddle { get; set; }

    public double? PnetFixedNumberCustomers { get; set; }

    public bool? PnetFlagStateApprovalSent { get; set; }

    public int? PnetFlagStateStartWorkflow { get; set; }

    public int? PnetFlagStateTransition { get; set; }

    public int? PnetFormType { get; set; }

    public bool? PnetFutureDreamBusiness { get; set; }

    public bool? PnetFutureDreamFamily { get; set; }

    public bool? PnetGoodPayment { get; set; }

    public double? PnetHigher30DayPaymentMethod { get; set; }

    public double? PnetHighMonthFactor2 { get; set; }

    public int? PnetHouseType { get; set; }

    public double? PnetInterestRate { get; set; }

    public int? PnetJanuary { get; set; }

    public int? PnetJuly { get; set; }

    public int? PnetJune { get; set; }

    public double? PnetLabor1 { get; set; }

    public double? PnetLabor2 { get; set; }

    public double? PnetLabor3 { get; set; }

    public double? PnetLocal { get; set; }

    public double? PnetMachineryEquipment { get; set; }

    public double? PnetMachines { get; set; }

    public int? PnetManagement { get; set; }

    public int? PnetMarch { get; set; }

    public int? PnetMay { get; set; }

    public bool? PnetMechangeEvaluated { get; set; }

    public double? PnetMerchandises { get; set; }

    public bool? PnetMicroempresaExcellence { get; set; }

    public double? PnetMiddleMonthFactor { get; set; }

    public double? PnetMinimumEstimatedExpenditure { get; set; }

    public bool? PnetMircorempresaInherited { get; set; }

    public int? PnetMonthFirstQuota { get; set; }

    public double? PnetMonthlyAmountPurchase { get; set; }

    public decimal? PnetMtabilityToPay { get; set; }

    public decimal? PnetMtabilityToPay2 { get; set; }

    public double? PnetMtamountFees { get; set; }

    public double? PnetMtamountRecorded { get; set; }

    public double? PnetMtaverageSalesMonth { get; set; }

    public decimal? PnetMtcapactyPaymentAdjusted { get; set; }

    public decimal? PnetMtcapactyPaymentAdjusted2 { get; set; }

    public string? PnetMtchangesCorrectionFactor { get; set; }

    public double? PnetMtcorrectionFactor { get; set; }

    public double? PnetMtcorrectionFactor2 { get; set; }

    public decimal? PnetMtcorrectionFactorPromeCurrentDebt { get; set; }

    public double? PnetMtcorrectionFactorPromeCurrentDebt2 { get; set; }

    public double? PnetMtcorrectionFactorRenovation { get; set; }

    public double? PnetMtcpaaverageMonth { get; set; }

    public double? PnetMtcpaverageMonth { get; set; }

    public string? PnetMtcreditHistoryObservation { get; set; }

    public DateTime? PnetMtcreditLiquidationDate { get; set; }

    public int? PnetMtcreditRatingHistory { get; set; }

    public double? PnetMtdebt { get; set; }

    public double? PnetMtdebt2 { get; set; }

    public string? PnetMtdelayed { get; set; }

    public bool? PnetMteverDelayed { get; set; }

    public double? PnetMtfamilyExpenditures { get; set; }

    public double? PnetMtfamilyExpenditures2 { get; set; }

    public int? PnetMtfeesPaid { get; set; }

    public double? PnetMtfixedCost { get; set; }

    public double? PnetMtfixedCost2 { get; set; }

    public int? PnetMtmaximumProduce { get; set; }

    public int? PnetMtmonthlyPurchase { get; set; }

    public string? PnetMtmonthType { get; set; }

    public string? PnetMtobservations { get; set; }

    public decimal? PnetMtoperatingIncome { get; set; }

    public decimal? PnetMtoperatingIncome2 { get; set; }

    public double? PnetMtotherIncome { get; set; }

    public double? PnetMtotherIncome2 { get; set; }

    public int? PnetMtpaymentBehavior { get; set; }

    public double? PnetMtprice { get; set; }

    public double? PnetMtpromeAdjustedDebt { get; set; }

    public double? PnetMtpromeAdjustedDebt2 { get; set; }

    public double? PnetMtpromeDebt { get; set; }

    public double? PnetMtpromeDebt2 { get; set; }

    public double? PnetMtquantityPurchase { get; set; }

    public string? PnetMtriskFocus { get; set; }

    public decimal? PnetMtsabilityToPay { get; set; }

    public double? PnetMtsamountFees { get; set; }

    public double? PnetMtsamountRecorded { get; set; }

    public decimal? PnetMtscapactyPaymentAdjusted { get; set; }

    public string? PnetMtschangesCorrectionFactor { get; set; }

    public double? PnetMtscorrectionfactor { get; set; }

    public double? PnetMtscorrectionFactorPromeCurrentDebt { get; set; }

    public double? PnetMtscorrectionFactorRenovation { get; set; }

    public string? PnetMtscostsObservation { get; set; }

    public double? PnetMtscpaaverageMonth { get; set; }

    public double? PnetMtscpaverageMonth { get; set; }

    public int? PnetMtscreditHistory { get; set; }

    public string? PnetMtscreditHistoryObservation { get; set; }

    public DateTime? PnetMtscreditLiquidationDate { get; set; }

    public double? PnetMtsdebt { get; set; }

    public string? PnetMtsdelayed { get; set; }

    public bool? PnetMtseverDelayed { get; set; }

    public double? PnetMtsexecutiveMonthMiddle { get; set; }

    public double? PnetMtsfamilyExpenditures { get; set; }

    public int? PnetMtsfeesPaid { get; set; }

    public double? PnetMtsfixedCost { get; set; }

    public string? PnetMtsobservations { get; set; }

    public decimal? PnetMtsoperatingIncome { get; set; }

    public double? PnetMtsotherIncome { get; set; }

    public double? PnetMtspatrimonialClassification { get; set; }

    public int? PnetMtspaymentBehavior { get; set; }

    public int? PnetMtspermanenceRating { get; set; }

    public double? PnetMtspromeAdjustedDebt { get; set; }

    public double? PnetMtspromeDebt { get; set; }

    public int? PnetMtsqualityRecords { get; set; }

    public string? PnetMtsqualityRecordsObservation { get; set; }

    public double? PnetMtssubTotalVariableCost { get; set; }

    public int? PnetMtsterm { get; set; }

    public double? PnetMtstotalCost { get; set; }

    public double? PnetMtstotalSales { get; set; }

    public double? PnetMtstotalVariableCost { get; set; }

    public double? PnetMtsvariableCost { get; set; }

    public int? PnetMtswillingnessPay { get; set; }

    public string? PnetMtswillingnessPayObservations { get; set; }

    public int? PnetMtterm { get; set; }

    public double? PnetMttotalCost { get; set; }

    public double? PnetMttotalCost2 { get; set; }

    public double? PnetMttotalSales { get; set; }

    public double? PnetMttotalSales2 { get; set; }

    public double? PnetMtvariableCost { get; set; }

    public double? PnetMtvariableCost2 { get; set; }

    public double? PnetMtvariableCostsSubTotal { get; set; }

    public double? PnetMtvariableCostsTotal { get; set; }

    public double? PnetNoRecords { get; set; }

    public int? PnetNovember { get; set; }

    public int? PnetNumberMonthlyPurchases { get; set; }

    public int? PnetOctober { get; set; }

    public decimal? PnetOperationalResultsHigh { get; set; }

    public decimal? PnetOperationalResultsLow { get; set; }

    public decimal? PnetOperationalResultsMiddle { get; set; }

    public bool? PnetOtherActive { get; set; }

    public double? PnetOtherCirculatingActives { get; set; }

    public double? PnetOtherFamilyExpenses { get; set; }

    public double? PnetOtherFixedActives { get; set; }

    public double? PnetOtherIncomeMonthHigh { get; set; }

    public double? PnetOtherIncomeMonthLow { get; set; }

    public double? PnetOtherIncomeMonthMiddle { get; set; }

    public double? PnetOtherPaymentMethod { get; set; }

    public double? PnetOthers { get; set; }

    public double? PnetOthersCirculatingPassives { get; set; }

    public double? PnetOthersPassives { get; set; }

    public double? PnetOthersProperties { get; set; }

    public double? PnetOwnHouse { get; set; }

    public double? PnetPapers { get; set; }

    public double? PnetPatrimonialClassification { get; set; }

    public string? PnetPatrimonialObservations { get; set; }

    public double? PnetPatrimonialSolidityTotal { get; set; }

    public decimal? PnetPayCapacityAdjustedMonthHigh { get; set; }

    public decimal? PnetPayCapacityAdjustedMonthLow { get; set; }

    public decimal? PnetPayCapacityAdjustedMonthMiddle { get; set; }

    public decimal? PnetPayCapacityMonthHigh { get; set; }

    public decimal? PnetPayCapacityMonthLow { get; set; }

    public decimal? PnetPayCapacityMonthMiddle { get; set; }

    public decimal? PnetPayCapacityPeriod { get; set; }

    public bool? PnetPayFees { get; set; }

    public int? PnetPermanence { get; set; }

    public string? PnetPermanenceObservation { get; set; }

    public int? PnetPermanenceRating { get; set; }

    public bool? PnetPositiveReferences { get; set; }

    public bool? PnetPreferenceRate { get; set; }

    public double? PnetPrivateEducation { get; set; }

    public string? PnetProductName1 { get; set; }

    public string? PnetProductName2 { get; set; }

    public string? PnetProductName3 { get; set; }

    public int? PnetProductQuantity1 { get; set; }

    public int? PnetProductQuantity2 { get; set; }

    public int? PnetProductQuantity3 { get; set; }

    public bool? PnetPromebehavior { get; set; }

    public double? PnetProviders { get; set; }

    public int? PnetPurchaseMethod { get; set; }

    public int? PnetQualityRecordSales { get; set; }

    public string? PnetQualityRecordsObservation { get; set; }

    public int? PnetQuotasNumber { get; set; }

    public double? PnetRawMaterial1 { get; set; }

    public double? PnetRawMaterial2 { get; set; }

    public double? PnetRawMaterial3 { get; set; }

    public double? PnetRawMaterials { get; set; }

    public DateTime? PnetRegistrationDateAfip { get; set; }

    public int? PnetRemunerationType { get; set; }

    public bool? PnetRenovation { get; set; }

    public double? PnetRent { get; set; }

    public int? PnetReportType { get; set; }

    public bool? PnetReputationCommercialBasis { get; set; }

    public double? PnetSaleMonthHigh { get; set; }

    public double? PnetSaleMonthLow { get; set; }

    public double? PnetSaleMonthMiddle { get; set; }

    public double? PnetSalePrice1 { get; set; }

    public double? PnetSalePrice2 { get; set; }

    public double? PnetSalePrice3 { get; set; }

    public double? PnetSalesImpact1 { get; set; }

    public double? PnetSalesImpact2 { get; set; }

    public double? PnetSalesImpact3 { get; set; }

    public double? PnetSalesMonthHigh { get; set; }

    public double? PnetSalesMonthLow { get; set; }

    public double? PnetSalesMonthMedium { get; set; }

    public int? PnetSeptember { get; set; }

    public double? PnetSocialWork { get; set; }

    public double? PnetSports { get; set; }

    public double? PnetSubtotalExpenditures { get; set; }

    public double? PnetTotalActives { get; set; }

    public double? PnetTotalAdjustedRevenue { get; set; }

    public double? PnetTotalCirculatingActives { get; set; }

    public double? PnetTotalCirculatingPassives { get; set; }

    public double? PnetTotalCostMonthHigh { get; set; }

    public double? PnetTotalCostMonthLow { get; set; }

    public double? PnetTotalCostMonthMiddle { get; set; }

    public double? PnetTotalFamilyBusinessDebts { get; set; }

    public double? PnetTotalFamilyExpenditure { get; set; }

    public int? PnetTotalFamilyGroup { get; set; }

    public double? PnetTotalFixedActives { get; set; }

    public double? PnetTotalFixedCosts { get; set; }

    public double? PnetTotalFixedCosts10 { get; set; }

    public int? PnetTotalMonthHigh { get; set; }

    public int? PnetTotalMonthLow { get; set; }

    public int? PnetTotalMonthMedium { get; set; }

    public double? PnetTotalPassiveLongTerm { get; set; }

    public double? PnetTotalPassives { get; set; }

    public double? PnetTotalSalesMonthHigh { get; set; }

    public double? PnetTotalSalesMonthLow { get; set; }

    public double? PnetTotalSalesMonthMiddle { get; set; }

    public double? PnetUnderMonthFactor { get; set; }

    public double? PnetUnderMonthFactor2 { get; set; }

    public double? PnetVariableCostMonthHigh { get; set; }

    public double? PnetVariableCostMonthLow { get; set; }

    public double? PnetVariableCostMonthMiddle { get; set; }

    public string? PnetVariableCostsObservations { get; set; }

    public double? PnetVariableCostsSubTotal { get; set; }

    public double? PnetVariableCostsTotal { get; set; }

    public double? PnetVariableNumberCustomers { get; set; }

    public double? PnetVehicles { get; set; }

    public decimal? PnetRollupTotalAdjustedRevenue { get; set; }

    public DateTime? PnetRollupTotalAdjustedRevenueDate { get; set; }

    public int? PnetRollupTotalAdjustedRevenueState { get; set; }

    public decimal? PnetRollupTotalFamilyBusinessDebts { get; set; }

    public DateTime? PnetRollupTotalFamilyBusinessDebtsDate { get; set; }

    public int? PnetRollupTotalFamilyBusinessDebtsState { get; set; }

    public decimal? PnetRollupTotalFixedCost { get; set; }

    public DateTime? PnetRollupTotalFixedCostDate { get; set; }

    public int? PnetRollupTotalFixedCostState { get; set; }

    public Guid? PnetCounterId { get; set; }

    public Guid? PnetAffectedAreaId { get; set; }

    public Guid? PnetRequestId { get; set; }

    public Guid? PnetParameterId { get; set; }

    public Guid? PnetRecordCommitteeId { get; set; }

    public Guid? PnetRiskAnalysisId { get; set; }

    public Guid? PnetExecutiveNameId { get; set; }

    public Guid? PnetMtevaluatorExecutive { get; set; }

    public Guid? PnetMtsevaluatorExecutive { get; set; }

    public int? PnetAgreement { get; set; }

    public DateTime? PnetApprobationDate1 { get; set; }

    public DateTime? PnetApprobationDate2 { get; set; }

    public DateTime? PnetApprobationDate3 { get; set; }

    public double? PnetAtoPayEigthMonth { get; set; }

    public double? PnetAtoPayElvenMonth { get; set; }

    public double? PnetAtoPayFiveMonth { get; set; }

    public double? PnetAtoPayFourMonth { get; set; }

    public double? PnetAtoPayNineMonth { get; set; }

    public double? PnetAtoPayOneMonth { get; set; }

    public double? PnetAtoPaySevenMonth { get; set; }

    public double? PnetAtoPaySixMonth { get; set; }

    public double? PnetAtoPayTenMonth { get; set; }

    public double? PnetAtoPayThreeMonth { get; set; }

    public double? PnetAtoPayTwelveMonth { get; set; }

    public double? PnetAtoPayTwoMonth { get; set; }

    public bool? PnetBackCar { get; set; }

    public double? PnetBackCarValue { get; set; }

    public bool? PnetBackHouse { get; set; }

    public double? PnetBackHouseValue { get; set; }

    public bool? PnetBackMachines { get; set; }

    public double? PnetBackMachinesValue { get; set; }

    public bool? PnetBackOthersProperties { get; set; }

    public double? PnetBackOthersPropertiesValue { get; set; }

    public int? PnetBanco { get; set; }

    public double? PnetBeigthMonth { get; set; }

    public double? PnetBelevenMonth { get; set; }

    public double? PnetBfiveMonth { get; set; }

    public double? PnetBfourMonth { get; set; }

    public double? PnetBnineMonth { get; set; }

    public double? PnetBoneMonth { get; set; }

    public double? PnetBsevenMonth { get; set; }

    public double? PnetBsixMonth { get; set; }

    public double? PnetBtenMonth { get; set; }

    public double? PnetBthreeMonth { get; set; }

    public double? PnetBtwelveMonth { get; set; }

    public double? PnetBtwoMonth { get; set; }

    public string? PnetCganancias { get; set; }

    public string? PnetCingbr { get; set; }

    public string? PnetCiva { get; set; }

    public int? PnetCmodalidad { get; set; }

    public int? PnetCommitmentdate { get; set; }

    public int? PnetConsultations { get; set; }

    public string? PnetCpacauseChanges { get; set; }

    public decimal? PnetCparesult { get; set; }

    public bool? PnetCpincreased { get; set; }

    public decimal? PnetCpresult { get; set; }

    public string? PnetCreditHistoryObservation { get; set; }

    public string? PnetCustomer1 { get; set; }

    public string? PnetCustomer2 { get; set; }

    public string? PnetCustomer3 { get; set; }

    public int? PnetDeal { get; set; }

    public DateTime? PnetEffectiveDateLiquidation { get; set; }

    public string? PnetEigthMonth { get; set; }

    public string? PnetElevenMonth { get; set; }

    public string? PnetEverSheDelayed { get; set; }

    public bool? PnetExceptionsDebtLevel2 { get; set; }

    public double? PnetFamilyExpensesccordingMe { get; set; }

    public string? PnetFiveMonth { get; set; }

    public int? PnetFixedSalary { get; set; }

    public bool? PnetFlagUcctoUccr { get; set; }

    public string? PnetFociAsMinimizingRisksAnd { get; set; }

    public int? PnetFormal { get; set; }

    public string? PnetFourMonth { get; set; }

    public DateTime? PnetGeoPositioining { get; set; }

    public string? PnetGetId { get; set; }

    public int? PnetImpactonRm { get; set; }

    public int? PnetIndependent { get; set; }

    public int? PnetInformal { get; set; }

    public bool? PnetLlapre { get; set; }

    public bool? PnetLlare { get; set; }

    public string? PnetLog { get; set; }

    public string? PnetMotivators { get; set; }

    public int? PnetNetAmount { get; set; }

    public double? PnetNewProductQuantity1 { get; set; }

    public double? PnetNewProductQuantity2 { get; set; }

    public double? PnetNewProductQuantity3 { get; set; }

    public string? PnetNineMonth { get; set; }

    public double? PnetNpa { get; set; }

    public double? PnetNpb { get; set; }

    public double? PnetNpc { get; set; }

    public double? PnetNpd { get; set; }

    public int? PnetObservation { get; set; }

    public string? PnetObservationsRenewal { get; set; }

    public string? PnetOneMonth { get; set; }

    public int? PnetOpcreditSubType { get; set; }

    public int? PnetOpcreditType { get; set; }

    public string? PnetOpportunities { get; set; }

    public string? PnetOpportunityId { get; set; }

    public string? PnetOpprincipalApplication { get; set; }

    public int? PnetOpreportType { get; set; }

    public double? PnetPa { get; set; }

    public int? PnetPaymentBehavior { get; set; }

    public double? PnetPb { get; set; }

    public double? PnetPc { get; set; }

    public double? PnetPd { get; set; }

    public double? PnetPreapprovedAmount { get; set; }

    public double? PnetPreapprovedFee { get; set; }

    public double? PnetPromeDebts { get; set; }

    public int? PnetQuotasPaid { get; set; }

    public double? PnetRa { get; set; }

    public double? PnetRb { get; set; }

    public double? PnetRc { get; set; }

    public double? PnetRd { get; set; }

    public double? PnetRenovationCorrectionFactor { get; set; }

    public decimal? PnetRenovationPayCapacity { get; set; }

    public decimal? PnetRenovationPayCapacityAdjusted { get; set; }

    public int? PnetReportGenerate { get; set; }

    public bool? PnetReportsGeneratePdf { get; set; }

    public string? PnetResponse { get; set; }

    public string? PnetRiskFactors { get; set; }

    public double? PnetSaa { get; set; }

    public int? PnetSalesCustomer1 { get; set; }

    public int? PnetSalesCustomer2 { get; set; }

    public int? PnetSalesCustomer3 { get; set; }

    public string? PnetSevenMonth { get; set; }

    public string? PnetSignature1 { get; set; }

    public string? PnetSignature2 { get; set; }

    public string? PnetSignature3 { get; set; }

    public string? PnetSixMonth { get; set; }

    public double? PnetSteIme { get; set; }

    public double? PnetSteMe { get; set; }

    public string? PnetStrengths { get; set; }

    public int? PnetSvcreditSubType { get; set; }

    public int? PnetSvcreditType { get; set; }

    public int? PnetSvreportType { get; set; }

    public string? PnetTenMonth { get; set; }

    public string? PnetTest { get; set; }

    public int? PnetTest2 { get; set; }

    public string? PnetThreeMonth { get; set; }

    public int? PnetTmov { get; set; }

    public DateTime? PnetToDateCb { get; set; }

    public double? PnetTotalFamilyandBusinessDebts { get; set; }

    public string? PnetTwelveMonth { get; set; }

    public string? PnetTwoMonth { get; set; }

    public int? PnetUnremunerative { get; set; }

    public int? PnetUrl { get; set; }

    public string? PnetUrlGetProductsByNip { get; set; }

    public string? PnetUrl01 { get; set; }

    public string? PnetUrl02 { get; set; }

    public string? PnetUrlgetProductsByNip1 { get; set; }

    public string? PnetUrlra { get; set; }

    public string? PnetUrlrc { get; set; }

    public DateTime? PnetVisitDate { get; set; }

    public string? PnetWhyChangesCorrectionFactor { get; set; }

    public string? PnetWhyDelayed { get; set; }

    public string? PnetWhyPaymentDateChanged { get; set; }

    public bool? PnetBackHouseCheck { get; set; }

    public Guid? PnetMicroEmpresa { get; set; }

    public Guid? PnetPrincipalApplication { get; set; }

    public Guid? PnetRenovationRequest { get; set; }

    public Guid? PnetSupplementaryRequest { get; set; }

    public Guid? PnetCommercialBackgrounds { get; set; }

    public Guid? PnetSiteVisitNumber { get; set; }

    public Guid? PnetReportTypeid { get; set; }

    public Guid? PnetRequestIdOpp { get; set; }

    public DateTime? PnetDateTest { get; set; }

    public bool? PnetCheckFixedCostsAdd { get; set; }

    public string? PnetCronopagoResult { get; set; }

    public string? PnetUrlExchangeNews { get; set; }

    public Guid? PnetCronopago { get; set; }

    public Guid? PnetOwnerEi { get; set; }

    public bool? PnetAccumulateExecute { get; set; }

    public bool? PnetAccumulateExecuteOk { get; set; }

    public int? PnetAmountRange { get; set; }

    public string? PnetBankResponse { get; set; }

    public int? PnetCreditDestination { get; set; }

    public string? PnetCreditTypification { get; set; }

    public double? PnetInterestRateAnual { get; set; }

    public double? PnetInterestRateMonthly { get; set; }

    public int? PnetRate { get; set; }

    public double? PnetRate1 { get; set; }

    public double? PnetRateApplied { get; set; }

    public bool? PnetRenewalAccumulate { get; set; }

    public int? PnetRenovationRequestManual { get; set; }

    public int? PnetSchema { get; set; }

    public int? PnetSetAcumRen { get; set; }

    public int? PnetSetValuesInterestrate { get; set; }

    public int? PnetSuraccount { get; set; }

    public string? PnetTermRange { get; set; }

    public int? PnetTermRanges { get; set; }

    public int? PnetUlcstatus { get; set; }

    public int? PnetQuotaExpirationDay { get; set; }

    public int? PnetContract { get; set; }

    public double? PnetCreditAmountSupplementary { get; set; }

    public double? PnetCreditAmountTitular { get; set; }

    public bool? PnetRequireRisk { get; set; }

    public string? PnetRequiresAccountOpening { get; set; }

    public DateTime? PnetLastSentDateColegiar { get; set; }

    public int? PnetPreviousInstance { get; set; }

    public bool? PnetClass1 { get; set; }

    public bool? PnetFlagAttributions { get; set; }

    public int? PnetPanelSin { get; set; }

    public int? PnetPreviousCategory { get; set; }

    public bool? PnetAgro { get; set; }

    public bool? PnetFreeInterestrate { get; set; }

    public decimal? PnetItpca { get; set; }

    public decimal? PnetMtacpca { get; set; }

    public decimal? PnetMtmppca { get; set; }

    public decimal? PnetMtspca { get; set; }

    public double? PnetPreApprovedAmountPa { get; set; }

    public int? PnetPreApprovedClassificationOp { get; set; }

    public double? PnetPreApprovedFeePa { get; set; }

    public Guid? PnetPreApprovedOpportunity { get; set; }

    public string? PnetDocumentUrl { get; set; }

    public int? PnetCampaignApprovalStatusStage { get; set; }

    public bool? PnetInCampaign { get; set; }

    public Guid? PnetCampaignResponseId { get; set; }

    public Guid? PnetOfferByMemberId { get; set; }

    public int? PnetQuotaOverdue { get; set; }

    public string? PnetLastcomment { get; set; }

    public Guid? PnetCurrentCollegiate { get; set; }

    public int? PnetAmortizationsystem { get; set; }

    public string? PnetCreditAmountletters { get; set; }

    public Guid? PnetBankLoanAgreement { get; set; }

    public Guid? PnetCustomerregistration { get; set; }

    public Guid? PnetValidateProcessUserId { get; set; }

    public string? TimeSpentByMeOnEmailAndMeetings { get; set; }

    public Guid? SlainvokedId { get; set; }

    public DateTime? LastOnHoldTime { get; set; }

    public int? OnHoldTime { get; set; }

    public Guid? Slaid { get; set; }

    public double? PnetPe { get; set; }

    public Guid? PnetExecutiveadministrator { get; set; }

    public decimal? PnetCredit1DebtAmount { get; set; }

    public decimal? PnetCredit2DebtAmount { get; set; }

    public int? PnetCreditDestinationBusinessHistory { get; set; }

    public Guid? PnetCreditToBeCancelled1 { get; set; }

    public Guid? PnetCreditToBeCancelled2 { get; set; }

    public int? PnetCursabip { get; set; }

    public decimal? PnetDebtAmount { get; set; }

    public double? PnetDebt { get; set; }

    public string? PnetMonthlyincome { get; set; }

    public double? PnetMonthlysales { get; set; }

    public double? PnetOtherincomes { get; set; }

    public double? PnetPaycapacityadjusted { get; set; }

    public string? ZennonbiScore { get; set; }

    public int? PnetAmortizationperiod { get; set; }

    public DateTime? PnetEnddategraceperiod { get; set; }

    public int? PnetGraceperiod { get; set; }

    public int? PnetSettlementperiod { get; set; }

    public int? PnetResultadosScoreDePuntaje { get; set; }

    public bool? PnetZonalChiefAuthorization { get; set; }

    public bool? PnetCreditocongarantiafogaba { get; set; }

    public bool? PnetCpcpaflow { get; set; }

    public bool? PnetDebtlevel { get; set; }

    public bool? PnetNegativebasisobs { get; set; }
}
