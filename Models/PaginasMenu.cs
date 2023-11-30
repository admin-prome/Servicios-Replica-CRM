using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PaginasMenu
{
    public int IdPaginaMenu { get; set; }

    public string? Colaborador { get; set; }

    public string Completo { get; set; } = null!;

    public string Personalizado { get; set; } = null!;

    public bool Particular { get; set; }

    public string ModificadoPor { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaModificacion { get; set; }

    public byte[] CTimestamp { get; set; } = null!;
}
