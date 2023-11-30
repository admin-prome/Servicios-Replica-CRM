using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class IcTarjetasAtesorada1
{
    public long IdTarjetasAtesorada { get; set; }

    public string? CodIdentificacion { get; set; }

    public string? DescIdentificacion { get; set; }

    public string? DescIdentifEmail { get; set; }

    public string? NumIdentifTelefono { get; set; }

    public string? CodCliente { get; set; }

    public string? DescCliente { get; set; }

    public string? DescTipoDocumento { get; set; }

    public string? NumDocumento { get; set; }

    public string? DescClienteEmail { get; set; }

    public string? NumClienteTelefono { get; set; }

    public string? FlaMicroempresa { get; set; }

    public string? NumTarjeta { get; set; }

    public string? CodUdn { get; set; }

    public string? DescUdn { get; set; }

    public string? FecStockDesde { get; set; }

    public DateTime? FechaProceso { get; set; }
}
