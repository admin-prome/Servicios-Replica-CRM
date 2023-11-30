using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class ProspectoOval
{
    public long IdProspectoOval { get; set; }

    public long? IdProspectoVeraz { get; set; }

    public int? OrdenId { get; set; }

    public string? AssignedTeam { get; set; }

    public string? AssignedUser { get; set; }

    public string? Branch { get; set; }

    public int? ContactId { get; set; }

    public decimal? CreditAmount { get; set; }

    public string? CreditSubtype { get; set; }

    public decimal? OfferCode { get; set; }

    public decimal? QuotaAmount { get; set; }

    public string? QuotasNumber { get; set; }

    public string? Segment { get; set; }

    public string? ToTeam { get; set; }

    public string? ToUser { get; set; }

    public string? Zone { get; set; }

    public int? Contacto { get; set; }

    public int? ConVisita { get; set; }

    public DateTime FechaCreación { get; set; }

    public string ArchConsulta { get; set; } = null!;

    public long Orden { get; set; }
}
