using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class CategoriasMonotributo
{
    public DateTime? Periodo { get; set; }

    public string? Categ { get; set; }

    public decimal? IngresosBrutos { get; set; }

    public string? Actividad { get; set; }
}
