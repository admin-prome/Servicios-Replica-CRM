using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class ProspectoVerazCodigo
{
    public int IdCodigos { get; set; }

    public string Entidad { get; set; } = null!;

    public string Columna { get; set; } = null!;

    public int Código { get; set; }

    public string Descripción { get; set; } = null!;

    public string CampañaSv { get; set; } = null!;

    public string CampañaCv { get; set; } = null!;

    public decimal NoBancarizado { get; set; }

    public decimal Bancarizado { get; set; }

    public bool BranchMatriz { get; set; }

    public bool AssignedTeamMatriz { get; set; }

    public bool ToTeamMatriz { get; set; }

    public DateTime? Modificado { get; set; }

    public string? ModificadoPor { get; set; }
}
