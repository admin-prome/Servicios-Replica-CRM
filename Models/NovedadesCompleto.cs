using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class NovedadesCompleto
{
    public Guid? Id { get; set; }

    public int? Documento { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Observaciones { get; set; }

    public Guid? Owner { get; set; }

    public int? Tipificacion { get; set; }

    public int? Agrupado { get; set; }

    public long IdRegistro { get; set; }
}
