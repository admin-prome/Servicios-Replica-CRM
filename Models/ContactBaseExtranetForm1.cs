using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class ContactBaseExtranetForm1
{
    public Guid? ContactId { get; set; }

    public int? StatusCode { get; set; }

    public string? StatusCodeDesc { get; set; }

    public DateTime? FechaCargaSolicitud { get; set; }

    public string? UsuarioCargaSolicitud { get; set; }

    public string? SucursalBapro { get; set; }

    public string? FullNameContacto { get; set; }

    public int? Cuitpre { get; set; }

    public long? Dni { get; set; }

    public int? Cuitdv { get; set; }

    public double? IngresoMensual { get; set; }

    public string Domicilio { get; set; } = null!;

    public string? Teléfono { get; set; }

    public string? Email { get; set; }

    public string? Rubro { get; set; }

    public string? Actividad { get; set; }

    public string? Segmento { get; set; }

    public int? DestinoCredito { get; set; }

    public int? CantEmpleados { get; set; }

    public int? DescripcionDestino { get; set; }

    public decimal? MontoCredito { get; set; }

    public int? Cuotas { get; set; }

    public string? Area1 { get; set; }

    public double? PnetTaxdocumentnumber { get; set; }

    public string? DescripcionActividad { get; set; }

    public int? Sexo { get; set; }

    public int? CnaeCodigo { get; set; }

    public string? CnaeDescripcion { get; set; }

    public DateTime? FechaEfectivaLiquidacion { get; set; }
}
