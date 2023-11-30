using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class IcCdniBip
{
    public long IdCdniBip { get; set; }

    public long? IdDCliente { get; set; }

    public int? CodAreaFijo1 { get; set; }

    public long? NumTelefonoFijo1 { get; set; }

    public int? CodAreaMovil1 { get; set; }

    public long? NumTelefonoMovil1 { get; set; }

    public string? EmailBip { get; set; }

    public DateTime? FecAltaEmailBip { get; set; }

    public string? FlaCdni { get; set; }

    public string? EmailCdni { get; set; }

    public DateTime? FecCdniAlta { get; set; }

    public int Eliminada { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaProceso { get; set; }
}
