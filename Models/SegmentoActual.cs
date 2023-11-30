using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class SegmentoActual
{
    public int? PnetDocumentNumber { get; set; }

    public string? PnetDocumentTypeValue { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? Rubro { get; set; }

    public string? Segmento { get; set; }

    public string? Actividad { get; set; }

    public long? Orden2 { get; set; }
}
