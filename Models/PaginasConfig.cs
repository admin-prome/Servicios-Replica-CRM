using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PaginasConfig
{
    public int IdConfiguracion { get; set; }

    public string Pagina { get; set; } = null!;

    public string? PaginaNombre { get; set; }

    public string Area { get; set; } = null!;

    public int? IdPlantilla { get; set; }

    public string? Cdestinarios { get; set; }

    public string? Cc { get; set; }

    public string? Cco { get; set; }

    public string? Permisos { get; set; }

    public bool Activo { get; set; }

    public string? Enlace { get; set; }

    /// <summary>
    /// Indica si el correo se envió en la fecha de consulta
    /// </summary>
    public bool CorreoEnviado { get; set; }

    public bool CorreoEnviadoResetear { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaModificacion { get; set; }

    public string ModificadoPor { get; set; } = null!;

    public string? CorreosPersonalizados { get; set; }

    public byte[] CTimestamp { get; set; } = null!;
}
