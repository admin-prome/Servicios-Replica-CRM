using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class Contacto
{
    public long IdContacto { get; set; }

    public long IdPersona { get; set; }

    public string? TipDoc { get; set; }

    public int? NroDoc { get; set; }

    public string? Direccion { get; set; }

    public string? Sucur { get; set; }

    public string? Domicilio { get; set; }

    public string? Localidad { get; set; }

    public string? CodigoPostal { get; set; }

    public string? Telefonos { get; set; }

    public int Estado { get; set; }

    public DateTime FechaCreación { get; set; }

    public DateTime FechaModificación { get; set; }

    public string Origen { get; set; } = null!;

    public decimal? Latitud { get; set; }

    public decimal? Longitud { get; set; }

    public string? Google { get; set; }
}
