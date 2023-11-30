using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class CampaignResponseBase
{
    public Guid ActivityId { get; set; }

    public int? PnetAgreement { get; set; }

    public int? PnetAmountRange { get; set; }

    public double? PnetCreditAmount { get; set; }

    public double? PnetCreditAmountNegotiation { get; set; }

    public int? PnetCreditDestination { get; set; }

    public string? PnetCreditTypification { get; set; }

    public string? PnetInteractionDescription { get; set; }

    public int? PnetInteractionQuotasNumber { get; set; }

    public double? PnetInterestRate { get; set; }

    public double? PnetInterestRateAnual { get; set; }

    public double? PnetNpa { get; set; }

    public double? PnetNpb { get; set; }

    public double? PnetNpc { get; set; }

    public double? PnetNpd { get; set; }

    public double? PnetOfferValueCreditAmount { get; set; }

    public double? PnetOfferValueQuotaAmount { get; set; }

    public double? PnetPa { get; set; }

    public double? PnetPb { get; set; }

    public double? PnetPc { get; set; }

    public double? PnetPd { get; set; }

    public int? PnetQuotasNumber { get; set; }

    public double? PnetQuotaValue { get; set; }

    public double? PnetQuotaValueNegotiation { get; set; }

    public int? PnetRate { get; set; }

    public double? PnetRb { get; set; }

    public double? PnetRc { get; set; }

    public double? PnetRd { get; set; }

    public bool? PnetRequireSiteVisit { get; set; }

    public double? PnetSaa { get; set; }

    public int? PnetSchema { get; set; }

    public int? PnetSetValuesInterestRate { get; set; }

    public int? PnetSubStatusCode { get; set; }

    public int? PnetTermRanges { get; set; }

    public Guid? PnetCampaniaRespuestaId { get; set; }

    public Guid? PnetContactId { get; set; }

    public Guid? PnetTopicId { get; set; }

    public Guid? PnetInteractionStatus { get; set; }

    public Guid? PnetInteractionSubStatus { get; set; }

    public Guid? PnetOfferValueId { get; set; }

    public Guid? PnetInteractionSaleStatus { get; set; }

    public Guid? PnetSaleStatus { get; set; }

    public Guid? PnetInteractionSaleSubStatus { get; set; }

    public Guid? PnetSaleSubStatus { get; set; }

    public int? PnetBuyingPropensity { get; set; }

    public Guid? PnetBusinessUnit { get; set; }

    public Guid? PnetExecutiveNameId { get; set; }

    public Guid? PnetContactOwner { get; set; }

    public bool? PnetManualEntreyRequest { get; set; }

    public int? PnetRenovationRequestManual { get; set; }

    public bool? PnetShowCloseCampaignFlag { get; set; }

    public Guid? PnetRenovationRequestId { get; set; }

    public double? PnetPe { get; set; }

    public double? PnetPf { get; set; }

    public double? PnetPg { get; set; }

    public DateTime? PnetFechafin { get; set; }

    public DateTime? PnetFechainicio { get; set; }

    public Guid? PnetConvenio { get; set; }

    public double? PnetTasa { get; set; }
}
