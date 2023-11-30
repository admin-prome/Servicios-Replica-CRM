using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class Cdni
{
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

    public string? NumCuit { get; set; }

    public string? FlagCdniComercios { get; set; }

    public string? FlagClienteCdni { get; set; }
}
