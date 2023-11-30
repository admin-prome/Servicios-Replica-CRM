using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class NivelesRiesgo
{
    public int IdNivelesRiesgo { get; set; }

    public DateTime SkFecha { get; set; }

    public string Grupo { get; set; } = null!;

    public decimal Minimo { get; set; }

    public decimal Maximo { get; set; }

    public string NivelTexto { get; set; } = null!;

    public short NivelNro { get; set; }

    public string Color { get; set; } = null!;

    public DateTime FechaProceso { get; set; }
}
