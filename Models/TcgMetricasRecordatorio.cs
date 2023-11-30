using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class TcgMetricasRecordatorio
{
    public int Legajo { get; set; }

    public DateTime? Periodo { get; set; }

    public string? Mail { get; set; }

    public string? Nombre { get; set; }

    public int? Q { get; set; }
}
