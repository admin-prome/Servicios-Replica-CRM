using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PerIncentivoConsultum
{
    public int IdIncentivo { get; set; }

    public string? Legajo { get; set; }

    public string? Porcentaje1 { get; set; }

    public string? Porcentaje2 { get; set; }

    public string? Nivel { get; set; }

    public string? Tratamiento { get; set; }

    public string? AdicionalRiesgo { get; set; }

    public string? Nota { get; set; }

    public string? ResultadoComercial { get; set; }

    public string? Target { get; set; }
}
