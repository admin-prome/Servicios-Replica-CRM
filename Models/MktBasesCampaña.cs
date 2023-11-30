using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class MktBasesCampaña
{
    public int IdBases { get; set; }

    public int? Año { get; set; }

    public int? Mes { get; set; }

    public string? Dni { get; set; }

    public string? NombreCliente { get; set; }

    public string? Campaña { get; set; }

    public decimal? Oferta { get; set; }

    public string? Zona { get; set; }

    public string? Sucursal { get; set; }

    public string? Mail { get; set; }

    public string? Tipo1 { get; set; }

    public string? Tel1 { get; set; }

    public string? Tipo2 { get; set; }

    public string? Tel2 { get; set; }

    public string? Tipo3 { get; set; }

    public string? Tel3 { get; set; }

    public string? TelefonoBanco { get; set; }

    public string? Archivo { get; set; }

    public string? IdProceso { get; set; }

    public DateTime FechaProceso { get; set; }

    public int Activa { get; set; }

    public string? Oval { get; set; }
}
