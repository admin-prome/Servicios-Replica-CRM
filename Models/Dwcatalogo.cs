using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class Dwcatalogo
{
    public string? Tabla { get; set; }

    public string? Columna { get; set; }

    public string Tipo { get; set; } = null!;

    public string EsquemaTabla { get; set; } = null!;

    public object? Notas { get; set; }
}
