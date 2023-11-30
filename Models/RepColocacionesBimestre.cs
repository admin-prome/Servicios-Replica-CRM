using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class RepColocacionesBimestre
{
    public string? Zona { get; set; }

    public int? Filial { get; set; }

    public string? Ec { get; set; }

    public int? Solicitud { get; set; }

    public string? Nombre { get; set; }

    public int? NroDocCliente { get; set; }

    public DateTime? FechaOtorgamiento { get; set; }

    public decimal? SaldoPrestamo { get; set; }

    public string? Sucursal { get; set; }

    public string? TipoCredito { get; set; }

    public decimal? Tasa { get; set; }

    public short? Plazo { get; set; }

    public string? SubTipoCredito { get; set; }

    public int? NroDocEc { get; set; }

    public long? Id { get; set; }

    public string? Posicion { get; set; }

    public DateTime? FechaDelDia { get; set; }

    public DateTime FechaProceso { get; set; }
}
