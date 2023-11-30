using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class IntCampaña1
{
    public long IdIntCampañas { get; set; }

    public string? CampaignName { get; set; }

    public string? OfferCode { get; set; }

    public string? CreditSubtype { get; set; }

    public string? CreditAmount { get; set; }

    public string? QuotaAmount { get; set; }

    public string? Zone { get; set; }

    public string? Branch { get; set; }

    public string? ContactId { get; set; }

    public string? AssignedTeam { get; set; }

    public string? ToTeam { get; set; }

    public string? Archivo { get; set; }

    public string? IdProceso { get; set; }

    public DateTime FechaProceso { get; set; }
}
