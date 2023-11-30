using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class VerazOvale
{
    public string? AssignedTeam { get; set; }

    public int? ContactId { get; set; }

    public DateTime? FechaConsulta { get; set; }

    public string? Categoria { get; set; }

    public string ConVisita { get; set; } = null!;

    public decimal? OfertaVeraz { get; set; }

    public decimal? CuotaVeraz { get; set; }

    public decimal? CreditAmount { get; set; }

    public decimal? QuotaAmount { get; set; }

    public decimal? OfferCode { get; set; }

    public string? CreditSubtype { get; set; }

    public string? ToTeam { get; set; }

    public string? Zone { get; set; }
}
