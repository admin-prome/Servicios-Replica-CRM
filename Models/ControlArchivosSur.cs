using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class ControlArchivosSur
{
    public int IdControl { get; set; }

    public int EstadoPadronSur { get; set; }

    public int EstadoCarteraSur { get; set; }

    public int EstadoBitacoraSur { get; set; }

    public int EstadoPromeLiquidados { get; set; }

    public int EstadoSolicitudesEnviadas { get; set; }

    public int EstadoMailingGestión { get; set; }

    public DateTime FechaModificación { get; set; }
}
