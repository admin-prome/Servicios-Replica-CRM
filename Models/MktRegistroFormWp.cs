using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class MktRegistroFormWp
{
    public long IdRegistroFormWp { get; set; }

    public long IdFormWp { get; set; }

    public long IdOrigen { get; set; }

    public string JsonData { get; set; } = null!;

    public DateTime FechaCreación { get; set; }

    public DateTime FechaModificación { get; set; }
}
