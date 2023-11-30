using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class NivelesIrregularidad1
{
    public int IdNivelesIrregularidad { get; set; }

    public string? Grupo { get; set; }

    public string? NivelTexto { get; set; }

    public string? Mínimo { get; set; }

    public string? Máximo { get; set; }

    public int NivelNro { get; set; }

    public string? Color { get; set; }

    public decimal? MinimoVal { get; set; }

    public decimal? MaximoVal { get; set; }

    public DateTime FechaProceso { get; set; }
}
