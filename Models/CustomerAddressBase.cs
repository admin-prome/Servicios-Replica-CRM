using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class CustomerAddressBase
{
    public Guid? ParentId { get; set; }

    public Guid? CustomerAddressId { get; set; }

    public int? AddressNumber { get; set; }

    public int? ObjectTypeCode { get; set; }

    public int? AddressTypeCode { get; set; }

    public string? Name { get; set; }

    public string? PrimaryContactName { get; set; }

    public string? Line1 { get; set; }

    public string? Line2 { get; set; }

    public string? Line3 { get; set; }

    public string? City { get; set; }

    public string? StateOrProvince { get; set; }

    public string? County { get; set; }

    public string? Country { get; set; }

    public string? PostOfficeBox { get; set; }

    public string? PostalCode { get; set; }

    public int? Utcoffset { get; set; }

    public int? FreightTermsCode { get; set; }

    public string? Upszone { get; set; }

    public double? Latitude { get; set; }

    public string? Telephone1 { get; set; }

    public double? Longitude { get; set; }

    public int? ShippingMethodCode { get; set; }

    public string? Telephone2 { get; set; }

    public string? Telephone3 { get; set; }

    public string? Fax { get; set; }

    public byte[]? VersionNumber { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? TimeZoneRuleVersionNumber { get; set; }

    public DateTime? OverriddenCreatedOn { get; set; }

    public int? UtcconversionTimeZoneCode { get; set; }

    public int? ImportSequenceNumber { get; set; }

    public Guid? CreatedOnBehalfBy { get; set; }

    public Guid? TransactionCurrencyId { get; set; }

    public decimal? ExchangeRate { get; set; }

    public Guid? ModifiedOnBehalfBy { get; set; }

    public int? ParentIdTypeCode { get; set; }

    public string? Composite { get; set; }
}
