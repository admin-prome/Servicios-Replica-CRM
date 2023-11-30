using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class AuxDefinicionCampo
{
    public string? Entidad { get; set; }

    public string? Columna { get; set; }

    public int? ValorCrm { get; set; }

    public string? ValorResultado { get; set; }

    public int? Idioma { get; set; }

    public int? DisplayOrder { get; set; }

    public int? ObjectTypeCode { get; set; }
}
