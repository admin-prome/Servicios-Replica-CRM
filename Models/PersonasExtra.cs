using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PersonasExtra
{
    public string? DocTipo { get; set; }

    public int? DocNro { get; set; }

    public DateTime? Cumpleaños { get; set; }

    public string? EstadoCivil { get; set; }

    public string? TeléfonoMóvil { get; set; }

    public int? MontoEstimado { get; set; }

    public string? DestinoDelCrédito { get; set; }

    public string? NivelDeEducación { get; set; }

    public int? CantidadDeHijos { get; set; }

    public bool? OtrosIngresos { get; set; }

    public string? PropietarioDeVehículo { get; set; }

    public int? CantidadDePersonasQueIntegranElHogar { get; set; }

    public string? TipoDeIngreso { get; set; }
}
