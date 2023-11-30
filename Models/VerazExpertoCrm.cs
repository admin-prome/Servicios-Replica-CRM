using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class VerazExpertoCrm
{
    public string? Nombre { get; set; }

    public int? Dni { get; set; }

    public string? Sexo { get; set; }

    public string? Sucursal { get; set; }

    public string? SucursalOrigen { get; set; }

    public string? Zona { get; set; }

    public string? Campaña { get; set; }

    public DateTime? FechaConsulta { get; set; }

    public int OvalPendiente { get; set; }

    public string? Oval { get; set; }

    public DateTime? FechaOval { get; set; }

    public string? Categoria { get; set; }

    public string? Explicacion { get; set; }

    public string? Cuota { get; set; }

    public string? PrestamoMaximo { get; set; }

    public string? LineaIntegracion { get; set; }

    public string ArchivoOriginal { get; set; } = null!;
}
