using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PnetAddressBaseExtranet
{
    public Guid PnetAddressId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public int? Statecode { get; set; }

    public int? Statuscode { get; set; }

    public string? PnetName { get; set; }

    public string? PnetBpbaAddressId { get; set; }

    public string? PnetAddress { get; set; }

    public string? PnetAddressNumber { get; set; }

    public string? PnetAddressNumberTo { get; set; }

    public string? PnetAddressType { get; set; }

    public int? PnetAddressTypeCode { get; set; }

    public string? PnetBpbaPersoninternalnumber { get; set; }

    public Guid? PnetContactId { get; set; }

    public string? PnetDepartment { get; set; }

    public string? PnetDistrictLocality { get; set; }

    public string? PnetDistrictLocalityCode { get; set; }

    public Guid? PnetDistrictLocalityId { get; set; }

    public string? PnetFloor { get; set; }

    public Guid? PnetLeadid { get; set; }

    public bool? PnetLinked { get; set; }

    public string? PnetNormalizationscounter { get; set; }

    public bool? PnetNormalized { get; set; }

    public string? PnetPostalCode { get; set; }

    public string? PnetProvince { get; set; }

    public int? PnetProvincecode { get; set; }
}
