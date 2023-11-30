using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class ResultadosFondep
{
    public long? Registro { get; set; }

    public long? Monto { get; set; }

    public string? Nombre { get; set; }

    public string? ErrorMesg { get; set; }

    public bool? ErrorCode { get; set; }

    public long? Dni { get; set; }

    public string? FondepFinal { get; set; }

    public string? Resultado { get; set; }

    public string? NombreOval { get; set; }

    public DateTime? FechaOval { get; set; }

    public long? Oval { get; set; }

    public int? Cuota { get; set; }

    public DateTime? FechaLote { get; set; }

    public string? PuntoCorte { get; set; }

    public string? SucursalCartera { get; set; }

    public string? ZonaCartera { get; set; }
}
