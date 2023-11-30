using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PerColaboradorCapacitacion
{
    public int IdColaborador { get; set; }

    public string? Nombre { get; set; }

    public int? Legajo { get; set; }

    public string? TipoFormación { get; set; }

    public string? NombreCurso { get; set; }

    public string? Proveedor { get; set; }

    public short? HorasCapacitación { get; set; }

    public string? Modalidad { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public int? CostoCurso { get; set; }

    public string? EstadoCurso { get; set; }

    public string? Carácter { get; set; }

    public string? EstadoEvaluación { get; set; }

    public decimal? PuntajeEvaluación { get; set; }

    public short? NroIntento { get; set; }

    public DateTime FechaProceso { get; set; }
}
