using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class ProcesosCarga
{
    public string NombreProceso { get; set; } = null!;

    public DateTime FechaEjecución { get; set; }

    /// <summary>
    /// Estado del proceso : 0 ejecutando | 1 finalizado
    /// </summary>
    public int Estado { get; set; }

    public Guid Guid { get; set; }
}
