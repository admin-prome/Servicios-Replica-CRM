using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class RepColocacionesEcBimestral
{
    public short? MetaQsucursal { get; set; }

    public decimal? MetaSucursal { get; set; }

    public string? EjecutivoSucursal { get; set; }

    public int? EjecutivoSucursalDoc { get; set; }

    public string? Sucursal { get; set; }

    public int? Filial { get; set; }

    public string? Ejecutivo { get; set; }

    public string? Zona { get; set; }

    public string? Categoria { get; set; }

    public int? MetaQ { get; set; }

    public int? Solicitud { get; set; }

    public decimal? MetaEjecutivo { get; set; }

    public decimal? SaldoPrestamo { get; set; }

    public short? Plazo { get; set; }

    public decimal? Tasa { get; set; }

    public string? TipoCredito { get; set; }

    public string? SubTipoCredito { get; set; }

    public string? Posicion { get; set; }

    public int? EjecutivoDoc { get; set; }

    public decimal? M1 { get; set; }

    public DateTime? PeriodoFin { get; set; }

    public string? Origen { get; set; }

    public DateTime FechaProceso { get; set; }

    public string? Rh30S0 { get; set; }

    public decimal? M1Suc { get; set; }
}
