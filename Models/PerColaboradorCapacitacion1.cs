using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PerColaboradorCapacitacion1
{
    public int IdColaborador { get; set; }

    public string? Nombre { get; set; }

    public string? Legajo { get; set; }

    public string? TipoFormación { get; set; }

    public string? NombreCurso { get; set; }

    public string? Proveedor { get; set; }

    public string? HorasCapacitación { get; set; }

    public string? Modalidad { get; set; }

    public string? FechaInicio { get; set; }

    public string? FechaFin { get; set; }

    public string? CostoCurso { get; set; }

    public string? EstadoCurso { get; set; }

    public string? Carácter { get; set; }

    public string? EstadoEvaluación { get; set; }

    public string? PuntajeEvaluación { get; set; }

    public string? NroIntento { get; set; }

    public DateTime FechaProceso { get; set; }
}
