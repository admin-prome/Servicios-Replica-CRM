using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PaginaRegistro
{
    public long IdPaginaRegistro { get; set; }

    public string Pagina { get; set; } = null!;

    public string Colaborador { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int Reloads { get; set; }

    public DateTime FechaCreación { get; set; }

    public DateTime FechaActualización { get; set; }

    public byte[] CTimestamp { get; set; } = null!;
}
