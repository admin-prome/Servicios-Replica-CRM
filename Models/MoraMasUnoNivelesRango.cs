using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class MoraMasUnoNivelesRango
{
    public int IdNivel { get; set; }

    public DateTime? SkFecha { get; set; }

    public string? Grupo { get; set; }

    public decimal? Minimo { get; set; }

    public decimal? Maximo { get; set; }

    public string? NivelTexto { get; set; }

    public short? NivelNro { get; set; }

    public string? Color { get; set; }

    public int EsBpba { get; set; }
}
