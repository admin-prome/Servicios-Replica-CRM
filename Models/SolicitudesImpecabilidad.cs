using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class SolicitudesImpecabilidad
{
    public int? Año { get; set; }

    public int Semana { get; set; }

    public DateTime? Periodo { get; set; }

    public int? Solicitudes { get; set; }

    public int? RechazadoLiq { get; set; }

    public int? RechazadoBancoLiq { get; set; }

    public int? Liquidado { get; set; }

    public int? RechazadosTotales { get; set; }

    public int? EjecutivoComercialVuelta { get; set; }

    public int? EjecutivoComercialIda { get; set; }

    public int? RechazadoQ { get; set; }

    public int? RechazadoBancoQ { get; set; }

    public int? NoContabilizar { get; set; }

    public int LegajoEcAdmin { get; set; }

    public string NombreEcAdmin { get; set; } = null!;

    public string GeneracionEcAdmin { get; set; } = null!;

    public string Zona { get; set; } = null!;

    public string SubZonaNombre { get; set; } = null!;

    public string Sucursal { get; set; } = null!;

    public int? FilialProme { get; set; }
}
