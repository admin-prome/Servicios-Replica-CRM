using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class CuadroDiarioEjecutivosMail
{
    public string? NombreEcAdm { get; set; }

    public int? LegajoEcAdm { get; set; }

    public string? CategoriaCodigo { get; set; }

    public string? Recipients { get; set; }

    public string? Subject { get; set; }

    public string? Body { get; set; }

    public string Importance { get; set; } = null!;

    public string FromAddress { get; set; } = null!;
}
