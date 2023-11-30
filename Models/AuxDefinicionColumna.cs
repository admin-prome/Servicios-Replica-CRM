using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class AuxDefinicionColumna
{
    public string? Entidad { get; set; }

    public string? Columna { get; set; }

    public string? Traducción { get; set; }

    public int? LanguageId { get; set; }
}
