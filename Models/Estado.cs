using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class Estado
{
    public int IdEstado { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripción { get; set; }
}
