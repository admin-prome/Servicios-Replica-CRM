using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PaginasNotificacion
{
    public int IdNotificacion { get; set; }

    public string Pagina { get; set; } = null!;

    public string Titulo { get; set; } = null!;

    public string Nota { get; set; } = null!;

    public DateTime FechaDesde { get; set; }

    public int Vigencia { get; set; }

    public DateTime? FechaHasta { get; set; }

    public bool Activo { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaModificacion { get; set; }

    public string ModificadoPor { get; set; } = null!;
}
