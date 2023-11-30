using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class RechazosBpbaaDw
{
    public DateTime SkFecha { get; set; }

    public string? Solicitud { get; set; }

    public int? NroDeDocumento { get; set; }

    public int? Nif { get; set; }

    public int? FilialBpba { get; set; }

    public string DetalleDelError { get; set; } = null!;

    public string Origen { get; set; } = null!;

    public string? Archivo { get; set; }

    public string IdProceso { get; set; } = null!;

    public DateTime FechaProceso { get; set; }
}
