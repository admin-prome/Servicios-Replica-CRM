using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class ExtBonificacionTasaProme
{
    public int BonificacionTasaPromeId { get; set; }

    public int ProyectoAsociativo { get; set; }

    public string? NombreProyectoAsociativo { get; set; }

    public string? CuitCooperativa { get; set; }

    public int? CantSolicitudes { get; set; }

    public string? DescripcionProyecto { get; set; }

    public string? UsuariosAsociadosJson { get; set; }

    public string? EstadoPrev { get; set; }

    public DateTime? FechaEfectivizacion { get; set; }

    public int ConfirmaMonto { get; set; }

    public decimal? MontoMonetizado { get; set; }

    public int? PlazoCredito { get; set; }

    public string? EstadoCredito { get; set; }

    public DateTime? FechaEfectCapTrabajo { get; set; }

    public int ConfirmaMontoCapTrabajo { get; set; }

    public decimal? MontoEfectMonetizado { get; set; }

    public int? PlazoCapTrabajo { get; set; }

    public string? EstadoCredCapTrabajo { get; set; }

    public Guid? ContactId { get; set; }

    public string? AdjuntosJson { get; set; }

    public string? CondicionTributaria { get; set; }

    public decimal? MontoIngresoMensual { get; set; }

    public string? TipoMonotributo { get; set; }

    public string? CuitRelacionado { get; set; }

    public string EstadoRegistro { get; set; } = null!;

    public DateTime FechaModificación { get; set; }

    public string ModificadoPor { get; set; } = null!;

    public byte[] Stamp { get; set; } = null!;
}
