using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class RepColocacionesColaboradore
{
    public string? Registro { get; set; }

    public string? Asistente { get; set; }

    public string? TotalFilial { get; set; }

    public string? Ejecutivo { get; set; }

    public string? Zona { get; set; }

    public string? SucursalOrden { get; set; }

    public int? Filial { get; set; }

    public string? Categoria { get; set; }

    public int? CantidadMeta { get; set; }

    public int? CantidadColocado { get; set; }

    public decimal? CumplimientoQ { get; set; }

    public decimal? CumplimientoQRepo { get; set; }

    public decimal? ImporteMeta { get; set; }

    public decimal? ImporteColocado { get; set; }

    public decimal? CumplimientoSRepo { get; set; }

    public decimal? Ppm { get; set; }

    public decimal? Tpm { get; set; }

    public decimal? M1 { get; set; }

    public int? Orden { get; set; }

    public string? Fecha { get; set; }

    public DateTime FechaProceso { get; set; }
}
