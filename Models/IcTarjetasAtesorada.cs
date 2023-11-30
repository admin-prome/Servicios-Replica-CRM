using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class IcTarjetasAtesorada
{
    public long IdTarjetasAtesorada { get; set; }

    public int? CodIdentificacion { get; set; }

    public string? DescIdentificacion { get; set; }

    public string? DescIdentifEmail { get; set; }

    public long? NumIdentifTelefono { get; set; }

    public long? CodCliente { get; set; }

    public string? DescCliente { get; set; }

    public string? DescTipoDocumento { get; set; }

    public long? NumDocumento { get; set; }

    public string? DescClienteEmail { get; set; }

    public long? NumClienteTelefono { get; set; }

    public string? FlaMicroempresa { get; set; }

    public long? NumTarjeta { get; set; }

    public int? CodUdn { get; set; }

    public string? DescUdn { get; set; }

    public DateTime? FecStockDesde { get; set; }

    public int Eliminada { get; set; }

    public DateTime? FechaProceso { get; set; }

    public DateTime FechaCreacion { get; set; }
}
