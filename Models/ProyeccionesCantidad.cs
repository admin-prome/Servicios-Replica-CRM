using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class ProyeccionesCantidad
{
    public string? Zona { get; set; }

    public int? CreditosLiquidadosMes { get; set; }

    public int? Ec { get; set; }

    public int? Ucc { get; set; }

    public int? Uccr { get; set; }

    public int? Riesgo { get; set; }

    public int? Doc { get; set; }

    public int? Banco { get; set; }

    public int? RechazadoBanco { get; set; }

    public int? Admision { get; set; }

    public int? Ei { get; set; }

    public int? Vt { get; set; }

    public int? TotalProyectado { get; set; }

    public int? ProyectadoCerrado { get; set; }

    public int? ProyectadoCerradoLiquidado { get; set; }

    public int? ProyectadoLiquidado { get; set; }

    public decimal? MetaQ { get; set; }

    public short? SinMetas { get; set; }

    public DateTime? FechaProceso { get; set; }

    public TimeSpan Actualizado { get; set; }
}
