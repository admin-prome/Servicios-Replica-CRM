using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class ProspectoVerazCrm
{
    public int IdProspectoVerazCrm { get; set; }

    public int? Dni { get; set; }

    public DateTime? FechaConsulta { get; set; }

    public double? Oferta { get; set; }

    public string? LineaCrm { get; set; }

    public string? PnetName { get; set; }

    public DateTime? CreatedOn { get; set; }
}
