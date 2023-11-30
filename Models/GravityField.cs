using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class GravityField
{
    public int SkForm { get; set; }

    public int SkField { get; set; }

    public long FieldId { get; set; }

    public string Label { get; set; } = null!;

    public string Type { get; set; } = null!;

    public bool IsRequired { get; set; }

    public long? CampoCrm { get; set; }

    public DateTime? Modificado { get; set; }

    public string? ModificadoPor { get; set; }
}
