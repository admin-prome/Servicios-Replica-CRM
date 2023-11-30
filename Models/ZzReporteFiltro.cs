using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class ZzReporteFiltro
{
    public int IdFiltro { get; set; }

    public int Nivel { get; set; }

    public string NombreNivel { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int? RefFiltro { get; set; }

    public int Qsubs { get; set; }

    public virtual ICollection<ZzReporteFiltro> InverseRefFiltroNavigation { get; set; } = new List<ZzReporteFiltro>();

    public virtual ZzReporteFiltro? RefFiltroNavigation { get; set; }
}
