using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class ZzDomiciliosCrm
{
    public string? DocTipo { get; set; }

    public int? DocNro { get; set; }

    public string? Composite { get; set; }

    public DateTime? Line1 { get; set; }

    public DateTime? City { get; set; }

    public DateTime? StateOrProvince { get; set; }

    public DateTime? PostalCode { get; set; }

    public DateTime? Calle { get; set; }

    public int? CalleNro { get; set; }

    public int? PnetDocumentNumber { get; set; }

    public DateTime? Zona { get; set; }

    public DateTime? Municipio { get; set; }

    public DateTime? Localidad { get; set; }

    public DateTime? PnetConsolidatePhone1 { get; set; }

    public DateTime? PnetConsolidatePhone2 { get; set; }

    public DateTime? PnetConsolidatePhone3 { get; set; }

    public DateTime? PnetConsolidatePhone4 { get; set; }
}
