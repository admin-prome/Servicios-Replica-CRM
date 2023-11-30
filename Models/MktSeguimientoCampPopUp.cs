using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class MktSeguimientoCampPopUp
{
    public long? IdPopUp { get; set; }

    public string? Dni { get; set; }

    public string? EntryDate { get; set; }

    public string? Origen { get; set; }

    public string? Medio { get; set; }

    public string? CampañaFormulario { get; set; }

    public string? Archivo { get; set; }

    public int? Año { get; set; }

    public int? Mes { get; set; }

    public string? NombreCliente { get; set; }

    public string? Campaña { get; set; }

    public string? Oval { get; set; }

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

    public long? EntryId { get; set; }

    public string? IdProceso { get; set; }

    public int Filial { get; set; }

    public string? FilialProme { get; set; }

    public string? SucursalCrm { get; set; }

    public string? ZonaCrm { get; set; }

    public string? SubZonaNombre { get; set; }

    public string SubZonaId { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? MailEc { get; set; }

    public int? Legajo { get; set; }
}
