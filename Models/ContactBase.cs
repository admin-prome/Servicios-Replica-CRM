using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class ContactBase
{
    public Guid? ContactId { get; set; }

    public Guid? DefaultPriceLevelId { get; set; }

    public int? CustomerSizeCode { get; set; }

    public int? CustomerTypeCode { get; set; }

    public int? PreferredContactMethodCode { get; set; }

    public int? LeadSourceCode { get; set; }

    public Guid? OriginatingLeadId { get; set; }

    public Guid? OwningBusinessUnit { get; set; }

    public int? PaymentTermsCode { get; set; }

    public int? ShippingMethodCode { get; set; }

    public bool? ParticipatesInWorkflow { get; set; }

    public bool? IsBackofficeCustomer { get; set; }

    public string? Salutation { get; set; }

    public string? JobTitle { get; set; }

    public string? FirstName { get; set; }

    public string? Department { get; set; }

    public string? NickName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Suffix { get; set; }

    public string? YomiFirstName { get; set; }

    public string? FullName { get; set; }

    public string? YomiMiddleName { get; set; }

    public string? YomiLastName { get; set; }

    public DateTime? Anniversary { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? GovernmentId { get; set; }

    public string? YomiFullName { get; set; }

    public string? Description { get; set; }

    public string? EmployeeId { get; set; }

    public int? GenderCode { get; set; }

    public decimal? AnnualIncome { get; set; }

    public int? HasChildrenCode { get; set; }

    public int? EducationCode { get; set; }

    public string? WebSiteUrl { get; set; }

    public int? FamilyStatusCode { get; set; }

    public string? FtpSiteUrl { get; set; }

    public string? EmailAddress1 { get; set; }

    public string? SpousesName { get; set; }

    public string? AssistantName { get; set; }

    public string? EmailAddress2 { get; set; }

    public string? AssistantPhone { get; set; }

    public string? EmailAddress3 { get; set; }

    public bool? DoNotPhone { get; set; }

    public string? ManagerName { get; set; }

    public string? ManagerPhone { get; set; }

    public bool? DoNotFax { get; set; }

    public bool? DoNotEmail { get; set; }

    public bool? DoNotPostalMail { get; set; }

    public bool? DoNotBulkEmail { get; set; }

    public bool? DoNotBulkPostalMail { get; set; }

    public int? AccountRoleCode { get; set; }

    public int? TerritoryCode { get; set; }

    public bool? IsPrivate { get; set; }

    public decimal? CreditLimit { get; set; }

    public DateTime? CreatedOn { get; set; }

    public bool? CreditOnHold { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public int? NumberOfChildren { get; set; }

    public string? ChildrensNames { get; set; }

    public byte[]? VersionNumber { get; set; }

    public string? MobilePhone { get; set; }

    public string? Pager { get; set; }

    public string? Telephone1 { get; set; }

    public string? Telephone2 { get; set; }

    public string? Telephone3 { get; set; }

    public string? Fax { get; set; }

    public decimal? Aging30 { get; set; }

    public int? StateCode { get; set; }

    public decimal? Aging60 { get; set; }

    public int? StatusCode { get; set; }

    public decimal? Aging90 { get; set; }

    public Guid? PreferredSystemUserId { get; set; }

    public Guid? PreferredServiceId { get; set; }

    public Guid? MasterId { get; set; }

    public int? PreferredAppointmentDayCode { get; set; }

    public int? PreferredAppointmentTimeCode { get; set; }

    public bool? DoNotSendMm { get; set; }

    public bool? Merged { get; set; }

    public string? ExternalUserIdentifier { get; set; }

    public Guid? SubscriptionId { get; set; }

    public Guid? PreferredEquipmentId { get; set; }

    public DateTime? LastUsedInCampaign { get; set; }

    public Guid? TransactionCurrencyId { get; set; }

    public DateTime? OverriddenCreatedOn { get; set; }

    public decimal? ExchangeRate { get; set; }

    public int? ImportSequenceNumber { get; set; }

    public int? TimeZoneRuleVersionNumber { get; set; }

    public int? UtcconversionTimeZoneCode { get; set; }

    public decimal? AnnualIncomeBase { get; set; }

    public decimal? CreditLimitBase { get; set; }

    public decimal? Aging60Base { get; set; }

    public decimal? Aging90Base { get; set; }

    public decimal? Aging30Base { get; set; }

    public Guid? OwnerId { get; set; }

    public Guid? CreatedOnBehalfBy { get; set; }

    public bool? IsAutoCreate { get; set; }

    public Guid? ModifiedOnBehalfBy { get; set; }

    public Guid? ParentCustomerId { get; set; }

    public int? ParentCustomerIdType { get; set; }

    public string? ParentCustomerIdName { get; set; }

    public int? OwnerIdType { get; set; }

    public string? ParentCustomerIdYomiName { get; set; }

    public Guid? ProcessId { get; set; }

    public Guid? EntityImageId { get; set; }

    public Guid? StageId { get; set; }

    public string? Business2 { get; set; }

    public string? Company { get; set; }

    public string? TraversedPath { get; set; }

    public string? Home2 { get; set; }

    public string? Callback { get; set; }

    public string? PnetAddress { get; set; }

    public int? PnetAddressNumber { get; set; }

    public string? PnetComment { get; set; }

    public int? PnetDocumentNumber { get; set; }

    public int? PnetDocumentType { get; set; }

    public string? PnetDocumentTypeValue { get; set; }

    public bool? PnetDwelling { get; set; }

    public int? PnetEstimatedAmount { get; set; }

    public bool? PnetFacebook { get; set; }

    public string? PnetFateCredit { get; set; }

    public string? PnetFatherName { get; set; }

    public int? PnetFee { get; set; }

    public bool? PnetFollowSocialNetworks { get; set; }

    public bool? PnetHasCommunityWork { get; set; }

    public bool? PnetHaveAccountOtherBank { get; set; }

    public bool? PnetHaveCreditCard { get; set; }

    public bool? PnetHaveCredits { get; set; }

    public bool? PnetHaveInsurance { get; set; }

    public bool? PnetHaveProductsBp { get; set; }

    public int? PnetLevelEducation { get; set; }

    public string? PnetLocationBirth { get; set; }

    public int? PnetMeansCommunication { get; set; }

    public int? PnetModel { get; set; }

    public string? PnetMotherName { get; set; }

    public string? PnetNameGenerator { get; set; }

    public string? PnetNationality { get; set; }

    public int? PnetNic { get; set; }

    public int? PnetNumberChildren { get; set; }

    public bool? PnetOthersIncomes { get; set; }

    public int? PnetOwnerVehicle { get; set; }

    public int? PnetPersonsHousehold { get; set; }

    public DateTime? PnetPuccreatedon { get; set; }

    public int? PnetRentalValue { get; set; }

    public string? PnetSource { get; set; }

    public double? PnetTaxDocumentNumber { get; set; }

    public int? PnetTaxDocumentType { get; set; }

    public int? PnetTypeBank { get; set; }

    public string? PnetTypeCredit { get; set; }

    public int? PnetTypeCreditCard { get; set; }

    public string? PnetTypeIncomes { get; set; }

    public string? PnetTypeInsurance { get; set; }

    public string? PnetTypeProductsBp { get; set; }

    public Guid? PnetMenameId { get; set; }

    public Guid? PnetRecommendedBusinessId { get; set; }

    public Guid? PnetRecommendedById { get; set; }

    public Guid? PnetPhoneCallId { get; set; }

    public Guid? PnetDistrictLocalityId { get; set; }

    public Guid? PnetSubsidiaryId { get; set; }

    public string? PnetBlock { get; set; }

    public string? PnetBody { get; set; }

    public string? PnetBpbaAddressDepartment { get; set; }

    public string? PnetBpbaAddressFlat { get; set; }

    public string? PnetBpbaAddressNumber { get; set; }

    public string? PnetBpbaAddressPostalCode { get; set; }

    public string? PnetBpbaAddressProvince { get; set; }

    public string? PnetBpbaAddressStreet { get; set; }

    public string? PnetBpbaDocumentNumber { get; set; }

    public string? PnetBpbaDocumentType { get; set; }

    public string? PnetBpbaEconomicActivityCode { get; set; }

    public string? PnetBpbaFiscalIdNumber { get; set; }

    public string? PnetBpbaFiscalIdNumberType { get; set; }

    public string? PnetBpbaOfficeInCharge { get; set; }

    public string? PnetBpbaPersonClasification { get; set; }

    public string? PnetBpbaPersonInternalNumber { get; set; }

    public string? PnetBpbaPersonSocialName { get; set; }

    public string? PnetDepartment { get; set; }

    public string? PnetFloor { get; set; }

    public string? PnetLocal { get; set; }

    public string? PnetLot { get; set; }

    public string? PnetNeighborhood { get; set; }

    public string? PnetObservationAddress { get; set; }

    public double? PnetPreApprovedAmount { get; set; }

    public double? PnetPreApprovedQuota { get; set; }

    public int? PnetStatus { get; set; }

    public double? PnetTaxDocumentNumber2 { get; set; }

    public double? PnetTaxDocumentNumber3 { get; set; }

    public string? PnetTower { get; set; }

    public string? PnetBpbaproducts { get; set; }

    public DateTime? PnetChangeStatusDate { get; set; }

    public int? PnetCodeStatusOld { get; set; }

    public int? PnetCodeSubStatusOld { get; set; }

    public bool? PnetCollectionSourcesValidated { get; set; }

    public bool? PnetMecreated { get; set; }

    public int? PnetPreferredMethodChannel { get; set; }

    public string? PnetPrincipalApplication { get; set; }

    public bool? PnetProductsService { get; set; }

    public string? PnetSubsidaryNumber { get; set; }

    public int? PnetSubsidiaryCode { get; set; }

    public int? PnetSubStatus { get; set; }

    public string? PnetUrlGetClientsByDni { get; set; }

    public string? PnetUrlGetDateTime { get; set; }

    public string? PnetUrlGetProductsFormattedByNip { get; set; }

    public string? PnetUrlGetRealAddressByNip { get; set; }

    public Guid? PnetCnaevalue { get; set; }

    public Guid? PnetCprincipalApplication { get; set; }

    public Guid? PnetPrincipalApplicationPreAp { get; set; }

    public bool? PnetBadFinancialBehavior { get; set; }

    public int? PnetCnaeval { get; set; }

    public bool? PnetGetSegOrConv { get; set; }

    public int? PnetRenovationNumber { get; set; }

    public bool? PnetPremiumCustomer { get; set; }

    public string? PnetBetweenStreets { get; set; }

    public string? PnetCorner { get; set; }

    public string? PnetExtraDetails { get; set; }

    public string? PnetJsonError { get; set; }

    public string? PnetJsonResult { get; set; }

    public int? PnetNationalityInformed { get; set; }

    public Guid? PnetCountryofbirth { get; set; }

    public Guid? PnetNationalityList { get; set; }

    public DateTime? PnetDeceasedDate { get; set; }

    public bool? PnetDeseasedCustomer { get; set; }

    public bool? AxxonClienteinterno { get; set; }

    public string? PnetAreaCode1 { get; set; }

    public string? PnetAreaCode2 { get; set; }

    public string? PnetAreaCode3 { get; set; }

    public string? PnetAreaCode4 { get; set; }

    public string? PnetConsolidatedBankPhone { get; set; }

    public string? PnetConsolidatePhone1 { get; set; }

    public string? PnetConsolidatePhone2 { get; set; }

    public string? PnetConsolidatePhone3 { get; set; }

    public string? PnetConsolidatePhone4 { get; set; }

    public string? PnetPhone1 { get; set; }

    public string? PnetPhone2 { get; set; }

    public string? PnetPhone3 { get; set; }

    public string? PnetPhone4 { get; set; }

    public int? PnetPhoneType1 { get; set; }

    public int? PnetPhoneType2 { get; set; }

    public int? PnetPhoneType3 { get; set; }

    public int? PnetPhoneType4 { get; set; }

    public int? PnetPreApprovedClassification { get; set; }

    public Guid? PnetUltimaofertavalorid { get; set; }

    public int? PnetInterestRate { get; set; }

    public string? PnetUrlGetProductsByNip { get; set; }

    public string? PnetBp88Barcode { get; set; }

    public int? PnetTaxGciascategory { get; set; }

    public int? PnetTaxIibbcategory { get; set; }

    public int? PnetTaxIvacategory { get; set; }

    public Guid? PnetNationalityId { get; set; }

    public Guid? CreatedByExternalParty { get; set; }

    public Guid? ModifiedByExternalParty { get; set; }

    public DateTime? LastOnHoldTime { get; set; }

    public Guid? Slaid { get; set; }

    public string? TimeSpentByMeOnEmailAndMeetings { get; set; }

    public int? OnHoldTime { get; set; }

    public bool? FollowEmail { get; set; }

    public Guid? SlainvokedId { get; set; }

    public bool? MarketingOnly { get; set; }

    public string? PnetCellPhone { get; set; }

    public string? PnetHistoricalObservations { get; set; }

    public string? PnetMobilePhone { get; set; }

    public string? PnetPhones { get; set; }

    public string? PnetTelephones { get; set; }

    public Guid? PnetBpbateamId { get; set; }

    public bool? PnetCustomerExcepted { get; set; }

    public int? PnetCustomerScore { get; set; }

    public Guid? PnetCommercialExecutiveAdministratorId { get; set; }

    public DateTime? PnetDeceasedRegistrationDate { get; set; }

    public string? PnetDeceasedRegistrationName { get; set; }

    public DateTime? PnetRegistrationDate { get; set; }

    public bool? PnetAddressCreation { get; set; }

    public bool? PnetBipcontact { get; set; }

    public DateTime? PnetBp730creation { get; set; }

    public bool? PnetBp730printed { get; set; }

    public bool? PnetCiudadano { get; set; }

    public int? PnetCodigoSituacion { get; set; }

    public string? PnetContractInternalNumber { get; set; }

    public bool? PnetDiplomaticoProfesorEstudianteDeportistaEu { get; set; }

    public bool? PnetDobleNacionalidad { get; set; }

    public int? PnetFatcasituation { get; set; }

    public DateTime? PnetFechaFinVigencia { get; set; }

    public bool? PnetFrecuenteEnEeuu { get; set; }

    public bool? PnetInternationalData { get; set; }

    public bool? PnetLinkage { get; set; }

    public string? PnetNacionalidadFiscal { get; set; }

    public Guid? PnetNationalityCountry { get; set; }

    public string? PnetNumeroDocumentoFiscalExtranjero { get; set; }

    public int? PnetOccupation { get; set; }

    public string? PnetOperativeContractIdentification { get; set; }

    public bool? PnetOrdenesTransferenciaPeriodicaCuentasEeuu { get; set; }

    public bool? PnetPadreMadreEstadounidense { get; set; }

    public bool? PnetPasaporteNorteamericano { get; set; }

    public bool? PnetPep { get; set; }

    public string? PnetPepreason { get; set; }

    public bool? PnetPhoneCreation { get; set; }

    public decimal? PnetPorcentajeExcencion { get; set; }

    public bool? PnetPoseeCuentaConjuntaFatca { get; set; }

    public string? PnetPrimerNacionalidad { get; set; }

    public bool? PnetRelacionadoConCorporaciones { get; set; }

    public bool? PnetRenunciaNacionalidadEeuu { get; set; }

    public bool? PnetResidente { get; set; }

    public string? PnetSegundaNacionalidad { get; set; }

    public bool? PnetSeleccionadoFatca { get; set; }

    public bool? PnetSeleccionadoOcde { get; set; }

    public bool? PnetSoi { get; set; }

    public int? PnetSoiType { get; set; }

    public bool? PnetSuscribioPoderNotarial { get; set; }

    public bool? PnetSwernDeclaration { get; set; }

    public int? PnetTipoDocumentoFiscalExtranjero { get; set; }

    public int? PnetTipoImpuesto { get; set; }

    public bool? PnetUifconstancy { get; set; }

    public bool? PnetCommercialaction { get; set; }

    public string? PnetCommercialactiondescription { get; set; }

    public string? ZennonbiActualscore { get; set; }
}
