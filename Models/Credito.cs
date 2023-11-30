using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class Credito
{
    public string? Solicitud { get; set; }

    public string? NroCta { get; set; }

    public Guid? BkCreditBase { get; set; }

    public bool? PnetAccepted { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? FechaCompromiso { get; set; }

    public string? EcEvaluador { get; set; }

    public int? EcEvaluadorDni { get; set; }

    public string? EcEvaluadorLegajo { get; set; }

    public int? EcAdminDni { get; set; }

    public string? EcAdminLegajo { get; set; }

    public string? EcAdminZona { get; set; }

    public DateTime FechaProceso { get; set; }
}
