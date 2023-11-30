using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class TecObjetivo
{
    public long IdObjetivo { get; set; }

    public string Area { get; set; } = null!;

    public int Legajo { get; set; }

    public string NombreMétrica { get; set; } = null!;

    public string? Descripción { get; set; }

    public long? IdObjetivoPredecesor { get; set; }

    public int IdEstado { get; set; }

    public DateTime FechaModificación { get; set; }

    public string? ModificadoPor { get; set; }

    public byte[] Stamp { get; set; } = null!;
}
