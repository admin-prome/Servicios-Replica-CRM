using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PrestamosLiquidadosNuevo
{
    public string? FechaDelDia { get; set; }

    public string Solicitud { get; set; } = null!;

    public int Tipo { get; set; }

    public long? NroDeDocumento { get; set; }

    public string? Nif { get; set; }

    public string? NombreDelCliente { get; set; }

    public string? Sucursal { get; set; }

    public string? Prod { get; set; }

    public string? CuentaSur { get; set; }

    public DateTime FechaProceso { get; set; }
}
