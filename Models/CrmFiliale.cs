using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class CrmFiliale
{
    public string? Zona { get; set; }

    public string? Sucursal { get; set; }

    public int? Filial { get; set; }

    public int? FilialProme { get; set; }

    public string? SubZonaNombre { get; set; }

    public string? NombreJefeZonal { get; set; }

    public string? SubZonaId { get; set; }
}
