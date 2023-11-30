using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class SolicitudesInstancia
{
    public string? Solicitud { get; set; }

    public string? Comentarios { get; set; }

    public string? InstanciaOrigen { get; set; }

    public string? InstanciaDestino { get; set; }

    public DateTime? Fecha { get; set; }

    public int? OpportunityBaseStatusCode { get; set; }

    public int? PnetAssessImpeccability { get; set; }

    public int? Orden { get; set; }
}
