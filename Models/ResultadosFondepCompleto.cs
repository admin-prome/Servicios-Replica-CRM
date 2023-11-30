using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class ResultadosFondepCompleto
{
    public long? Registro { get; set; }

    public long? Monto { get; set; }

    public string? Nombre { get; set; }

    public string? ErrorMesg { get; set; }

    public bool? ErrorCode { get; set; }

    public long? Dni { get; set; }

    public string? FondepFinal { get; set; }

    public string? Resultado { get; set; }

    public string? NombreOval { get; set; }

    public DateTime? FechaOval { get; set; }

    public long? Oval { get; set; }

    public int? Cuota { get; set; }

    public DateTime? FechaLote { get; set; }

    public string? PuntoCorte { get; set; }

    public string? SucursalCartera { get; set; }

    public string? ZonaCartera { get; set; }

    public string? SubzonaCartera { get; set; }

    public string? Solicitud { get; set; }

    public int? PnetSuraccount { get; set; }

    public DateTime? FechaLiquidación { get; set; }

    public double? MontoSolicitud { get; set; }

    public string? Zona { get; set; }

    public string? Subzona { get; set; }

    public string? Sucursal { get; set; }

    public string? SucursalCód { get; set; }

    public string? Ec { get; set; }

    public string? LegajoEc { get; set; }

    public string? Estado { get; set; }

    public string? Instancia { get; set; }

    public string? SubInstancia { get; set; }

    public string? Origen { get; set; }

    public decimal? TasaAnual { get; set; }

    public string? TipoFormulario { get; set; }

    public string? TipoCrédito { get; set; }

    public string? SubTipoCrédito { get; set; }

    public string? DocTipo { get; set; }

    public int? DocNro { get; set; }

    public string? Nif { get; set; }

    public int? Convenio { get; set; }

    public long? Orden { get; set; }
}
