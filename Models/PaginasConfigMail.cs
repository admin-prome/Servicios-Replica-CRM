using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PaginasConfigMail
{
    public int IdConfiguracion { get; set; }

    public string Pagina { get; set; } = null!;

    public string Area { get; set; } = null!;

    public int? IdPlantilla { get; set; }

    public string? Cdestinarios { get; set; }

    public string? Cc { get; set; }

    public string? Cco { get; set; }

    public int CorreoEnviado { get; set; }

    public string? Nombre { get; set; }

    public string? Notas { get; set; }

    public string? Asunto { get; set; }

    public string? Html { get; set; }

    public bool? Activa { get; set; }

    public string? Sector { get; set; }

    public DateTime? DiaHabil { get; set; }
}
