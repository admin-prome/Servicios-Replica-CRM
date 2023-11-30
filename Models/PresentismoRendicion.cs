using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PresentismoRendicion
{
    public int? Id { get; set; }

    public string? IdMotivo { get; set; }

    public string? IdEstado { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Destino { get; set; }

    public decimal? Km { get; set; }

    public string? IdConcepto { get; set; }

    public int? IdUsuario { get; set; }

    public string? CargadoEnCelular { get; set; }

    public int? NumeroLegajo { get; set; }

    public string? Email { get; set; }

    public string? CategoriaCodigo { get; set; }
}
