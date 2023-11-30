using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class ProductBase
{
    public Guid? ProductId { get; set; }

    public Guid? DefaultUoMscheduleId { get; set; }

    public Guid? SubjectId { get; set; }

    public Guid? OrganizationId { get; set; }

    public string? Name { get; set; }

    public Guid? DefaultUoMid { get; set; }

    public Guid? PriceLevelId { get; set; }

    public string? Description { get; set; }

    public int? ProductTypeCode { get; set; }

    public string? ProductUrl { get; set; }

    public decimal? Price { get; set; }

    public bool? IsKit { get; set; }

    public string? ProductNumber { get; set; }

    public string? Size { get; set; }

    public decimal? CurrentCost { get; set; }

    public decimal? StockVolume { get; set; }

    public decimal? StandardCost { get; set; }

    public decimal? StockWeight { get; set; }

    public int? QuantityDecimal { get; set; }

    public decimal? QuantityOnHand { get; set; }

    public bool? IsStockItem { get; set; }

    public string? SupplierName { get; set; }

    public string? VendorName { get; set; }

    public string? VendorPartNumber { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public int? StateCode { get; set; }

    public Guid? ModifiedBy { get; set; }

    public int? StatusCode { get; set; }

    public byte[]? VersionNumber { get; set; }

    public DateTime? OverriddenCreatedOn { get; set; }

    public Guid? TransactionCurrencyId { get; set; }

    public decimal? ExchangeRate { get; set; }

    public int? UtcconversionTimeZoneCode { get; set; }

    public int? ImportSequenceNumber { get; set; }

    public int? TimeZoneRuleVersionNumber { get; set; }

    public decimal? CurrentCostBase { get; set; }

    public decimal? PriceBase { get; set; }

    public decimal? StandardCostBase { get; set; }

    public Guid? ModifiedOnBehalfBy { get; set; }

    public Guid? CreatedOnBehalfBy { get; set; }

    public Guid? StageId { get; set; }

    public Guid? ProcessId { get; set; }

    public Guid? EntityImageId { get; set; }

    public int? ProductStructure { get; set; }

    public string? VendorId { get; set; }

    public Guid? ParentProductId { get; set; }

    public string? TraversedPath { get; set; }

    public DateTime? ValidToDate { get; set; }

    public DateTime? ValidFromDate { get; set; }

    public string? HierarchyPath { get; set; }

    public Guid? AxxonFormConfigId { get; set; }

    public Guid? ModifiedByExternalParty { get; set; }

    public Guid? CreatedByExternalParty { get; set; }
}
