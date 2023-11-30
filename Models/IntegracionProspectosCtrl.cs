using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class IntegracionProspectosCtrl
{
    public long EntryId { get; set; }

    public string? Observaciones { get; set; }

    public DateTime? FechaEntrada { get; set; }
}
