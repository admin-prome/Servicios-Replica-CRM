using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class Persona
{
    public long IdPersona { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public string NombreCompleto { get; set; } = null!;

    public string? Sexo { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public long? Nif { get; set; }

    public string? TipoDocumento { get; set; }

    public int? NroDoc { get; set; }

    public bool? Jurídica { get; set; }

    public string? Nacionalidad { get; set; }

    public DateTime FechaCreación { get; set; }

    public DateTime FechaModificación { get; set; }

    public string Origen { get; set; } = null!;
}
