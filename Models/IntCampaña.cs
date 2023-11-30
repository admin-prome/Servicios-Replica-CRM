using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class IntCampaña
{
    public long IdIntCampañas { get; set; }

    public string? CampaignName { get; set; }

    public string? CampaignNameVal { get; set; }

    public string? OfferCode { get; set; }

    public string? OfferCodeVal { get; set; }

    public string? CreditSubtype { get; set; }

    public string? CreditSubtypeVal { get; set; }

    public string? CreditAmount { get; set; }

    public string? CreditAmountVal { get; set; }

    public string? QuotaAmount { get; set; }

    public string? QuotaAmountVal { get; set; }

    public string? Zone { get; set; }

    public string? ZoneVal { get; set; }

    public string? Branch { get; set; }

    public string? BranchVal { get; set; }

    public string? ContactId { get; set; }

    public string? ContactIdVal { get; set; }

    public string? AssignedTeam { get; set; }

    public string? AssignedTeamVal { get; set; }

    public string? ToTeam { get; set; }

    public string? ToTeamVal { get; set; }

    public string? Observaciones { get; set; }

    public string Estado { get; set; } = null!;

    public bool? Válido { get; set; }

    public string Area { get; set; } = null!;

    public string? Archivo { get; set; }

    public string? IdProceso { get; set; }

    public DateTime FechaProceso { get; set; }

    public string? Oval { get; set; }

    public DateTime? FechaOval { get; set; }
}
