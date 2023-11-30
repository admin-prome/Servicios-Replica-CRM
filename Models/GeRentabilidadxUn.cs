using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class GeRentabilidadxUn
{
    public long IdRentabilidadxUn { get; set; }

    public DateTime? Periodo { get; set; }

    public decimal? RendimientoFinanciero { get; set; }

    public decimal? IngresosPorComisiones { get; set; }

    public decimal? Iibb { get; set; }

    public decimal? SueldosReal { get; set; }

    public decimal? SueldosRealSucursal { get; set; }

    public decimal? SueldosRealZonal { get; set; }

    public decimal? SueldosRealCmz { get; set; }

    public decimal? SueldosPresupuesto { get; set; }

    public decimal? SueldosPresupuestoSucursal { get; set; }

    public decimal? SueldosPresupuestoZonal { get; set; }

    public decimal? SueldosPresupuestoCmz { get; set; }

    public decimal? GaoReal { get; set; }

    public decimal? GaoRealSucursal { get; set; }

    public decimal? GaoRealZonal { get; set; }

    public decimal? GaoRealCmz { get; set; }

    public decimal? GaoRealZonalCentralizado { get; set; }

    public decimal? GaoPresupuesto { get; set; }

    public decimal? GaoPresupuestoSucursal { get; set; }

    public decimal? GaoPresupuestoZonal { get; set; }

    public decimal? GaoPresupuestoCmz { get; set; }

    public decimal? OtrosCostosOperativos { get; set; }

    public decimal? AmortizacionesEIngresosFinancieros { get; set; }

    public decimal? RendimientoFinancieroSucursal { get; set; }

    public decimal? IngresosPorComisionesSucursal { get; set; }

    public decimal? IibbSucursal { get; set; }

    public decimal? RendimientoFinancieroMatriz { get; set; }

    public decimal? IngresosPorComisionesMatriz { get; set; }

    public decimal? IibbMatriz { get; set; }

    public decimal? IngresosPorFacturacionReal { get; set; }

    public decimal? IngresosPorFacturacionRedMatriz { get; set; }

    public decimal? RendimientoFinancieroRedMatriz { get; set; }

    public decimal? IngresosPorComisionRedMatriz { get; set; }

    public decimal? IibbRedMatriz { get; set; }

    public string? CentroCostos { get; set; }

    public string? Zona { get; set; }

    public short? Año { get; set; }

    public short? Mes { get; set; }

    public string? Archivo { get; set; }

    public string? IdProceso { get; set; }

    public DateTime? FechaProceso { get; set; }

    public int Ver { get; set; }

    public string? Gerencia { get; set; }

    public decimal? RendimientoFinancieroZonal { get; set; }

    public decimal? IngresosPorComisionesZonal { get; set; }

    public decimal? IibbZonal { get; set; }
}
