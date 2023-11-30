using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PerNominaTalento1
{
    public int IdNominaTalentos { get; set; }

    public string? Legajo { get; set; }

    public string? Nombre { get; set; }

    public string? FechaAntiguedad { get; set; }

    public string? FechaBaja { get; set; }

    public string? MotivoBaja { get; set; }

    public string? Generacion { get; set; }

    public string? Zona { get; set; }

    public string? Perfil { get; set; }

    public string? Sector { get; set; }

    public string? Gerencia { get; set; }

    public string? CentroDeCostos { get; set; }

    public string? Categoria { get; set; }

    public DateTime Fechaproceso { get; set; }
}
