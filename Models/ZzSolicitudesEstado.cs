using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class ZzSolicitudesEstado
{
    public long IdSolicitudEstado { get; set; }

    public DateTime? Periodo { get; set; }

    public string? PnetName { get; set; }

    public int? Solicitud { get; set; }

    public string? PnetComment { get; set; }

    public Guid? PnetInstancesId { get; set; }

    public string? PnetPreviousState { get; set; }

    public string? PnetResultState { get; set; }

    public DateTime? FechaEstado { get; set; }

    public int? OpportunityBaseStatusCode { get; set; }

    public DateTime? OpportunityBaseCreatedOn { get; set; }

    public DateTime? PnetEffectiveDateLiquidation { get; set; }

    public long? EtapaMinutos { get; set; }

    public int? NroEtapa { get; set; }

    public int RechazadaFinal { get; set; }

    public int PnetAssessImpeccability { get; set; }
}
