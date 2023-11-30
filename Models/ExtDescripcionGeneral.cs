using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class ExtDescripcionGeneral
{
    public int DescripcionGeneralId { get; set; }

    public string? Codigo { get; set; }

    public string? CodDesc { get; set; }

    public string? Descripcion { get; set; }

    public string? Valor { get; set; }
}
