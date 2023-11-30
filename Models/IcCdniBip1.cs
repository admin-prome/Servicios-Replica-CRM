using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class IcCdniBip1
{
    public long IdCdniBip { get; set; }

    public string? IdDCliente { get; set; }

    public string? CodAreaFijo1 { get; set; }

    public string? NumTelefonoFijo1 { get; set; }

    public string? CodAreaMovil1 { get; set; }

    public string? NumTelefonoMovil1 { get; set; }

    public string? EmailBip { get; set; }

    public string? FecAltaEmailBip { get; set; }

    public string? FlaCdni { get; set; }

    public string? EmailCdni { get; set; }

    public string? FecCdniAlta { get; set; }

    public DateTime? FechaProceso { get; set; }
}
