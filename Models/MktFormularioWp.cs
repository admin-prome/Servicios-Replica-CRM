using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class MktFormularioWp
{
    public string? Dni { get; set; }

    public long? EntryId { get; set; }

    public string? EntryDate { get; set; }

    public string? Origen { get; set; }

    public string? Medio { get; set; }

    public string? Campaña { get; set; }

    public string? Archivo { get; set; }

    public string? IdProceso { get; set; }

    public DateTime? FechaProceso { get; set; }

    public int Activo { get; set; }
}
