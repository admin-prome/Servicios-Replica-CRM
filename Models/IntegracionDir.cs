using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class IntegracionDir
{
    public long IdIntegracionDir { get; set; }

    public string Integración { get; set; } = null!;

    public string Campo { get; set; } = null!;

    public string Descripción { get; set; } = null!;

    public int Orden { get; set; }

    public string? ValorPorDefecto { get; set; }

    public DateTime FechaModificacion { get; set; }

    public string ModificadoPor { get; set; } = null!;
}
