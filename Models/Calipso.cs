using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class Calipso
{
    public long IdgeCalipso { get; set; }

    public DateTime? Periodo { get; set; }

    public string? Clasificación { get; set; }

    public string? Línea { get; set; }

    public string? Rubro { get; set; }

    public string? Subrubro { get; set; }

    public string? Zona { get; set; }

    public string? Gerencia { get; set; }

    public string? CentroCostos { get; set; }

    public long? Código { get; set; }

    public string? Descripción { get; set; }

    public string? Proveedor { get; set; }

    public string? Idasiento { get; set; }

    public string? DetalleAsiento { get; set; }

    public long? NúmeroDocumento { get; set; }

    public DateTime? Fecha { get; set; }

    public string? CodProy { get; set; }

    public string? Proyecto { get; set; }

    public decimal? Real { get; set; }

    public decimal? RealAxI { get; set; }

    public decimal? Presupuesto { get; set; }

    public decimal? AjusteInflación { get; set; }

    public short? Año { get; set; }

    public short? Mes { get; set; }

    public string? Archivo { get; set; }

    public string? IdProceso { get; set; }

    public DateTime? FechaProceso { get; set; }
}
