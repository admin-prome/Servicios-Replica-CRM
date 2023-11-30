using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class ProyeccionesSaldo
{
    public string? Zona { get; set; }

    public decimal? MontoMes { get; set; }

    public decimal? Ec { get; set; }

    public decimal? Ucc { get; set; }

    public decimal? Uccr { get; set; }

    public decimal? Riesgo { get; set; }

    public decimal? Doc { get; set; }

    public decimal? Banco { get; set; }

    public decimal? RechazadoBanco { get; set; }

    public decimal? Admision { get; set; }

    public double? Ei { get; set; }

    public double? Vt { get; set; }

    public decimal? TotalProyectado { get; set; }

    public decimal? ProyectadoCerrado { get; set; }

    public decimal? ProyectadoCerradoLiquidado { get; set; }

    public decimal? ProyectadoLiquidado { get; set; }

    public decimal? Meta { get; set; }

    public DateTime? FechaProceso { get; set; }

    public TimeSpan Actualizado { get; set; }
}
