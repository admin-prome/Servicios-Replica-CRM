using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class FallecidosCrm
{
    public DateTime? FechaFallecimiento { get; set; }

    public string? RegistradoPor { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? StatusCode { get; set; }

    public bool? PnetDeseasedCustomer { get; set; }

    public int? DocNro { get; set; }

    public string? DocTipo { get; set; }

    public Guid? ContactId { get; set; }

    public DateTime FechaProceso { get; set; }
}
