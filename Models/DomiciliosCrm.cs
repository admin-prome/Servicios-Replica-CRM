using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class DomiciliosCrm
{
    public string? DocTipo { get; set; }

    public int? DocNro { get; set; }

    public string? Composite { get; set; }

    public string? Line1 { get; set; }

    public string? City { get; set; }

    public string? StateOrProvince { get; set; }

    public string? PostalCode { get; set; }

    public string? Calle { get; set; }

    public int? CalleNro { get; set; }

    public int? PnetDocumentNumber { get; set; }

    public string? Zona { get; set; }

    public string? Municipio { get; set; }

    public string? Localidad { get; set; }

    public string? PnetConsolidatePhone1 { get; set; }

    public string? PnetConsolidatePhone2 { get; set; }

    public string? PnetConsolidatePhone3 { get; set; }

    public string? PnetConsolidatePhone4 { get; set; }
}
