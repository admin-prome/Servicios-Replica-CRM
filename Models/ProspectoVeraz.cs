using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class ProspectoVeraz
{
    public string ArchConsulta { get; set; } = null!;

    public long Orden { get; set; }

    public int? Dni { get; set; }

    public string? Sexo { get; set; }

    public string? Nombre { get; set; }

    public string? Sucursal { get; set; }

    public string? SucursalOrigen { get; set; }

    public int? CodSucursal { get; set; }

    public int? CodSucProme { get; set; }

    public string? Zona { get; set; }

    public string? Campaign { get; set; }

    public int LeadSourceCode { get; set; }

    public int StatusCode { get; set; }

    public DateTime? FechaConsulta { get; set; }

    public int Pendiente { get; set; }

    public string? RespuestaVeraz { get; set; }

    public long IdProspectoVeraz { get; set; }

    public string? Otros { get; set; }
}
