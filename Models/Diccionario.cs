using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class Diccionario
{
    public long IdDiccionario { get; set; }

    public string Descriptor { get; set; } = null!;

    public string Campo { get; set; } = null!;

    public string Dato { get; set; } = null!;

    public string CodigoCrm { get; set; } = null!;
}
