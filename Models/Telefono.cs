using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class Telefono
{
    public long IdTelefono { get; set; }

    public long IdPersona { get; set; }

    public string Numero { get; set; } = null!;

    public string? TipoContacto { get; set; }

    public string? Área { get; set; }

    public string? NroLocal { get; set; }

    public int? Filial { get; set; }

    public string Origen { get; set; } = null!;

    public string Recibido { get; set; } = null!;

    public int Corregido { get; set; }

    public int Estado { get; set; }

    public DateTime FechaCreación { get; set; }

    public DateTime? FechaModificación { get; set; }

    public int? SkNomina { get; set; }
}
