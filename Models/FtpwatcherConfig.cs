using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class FtpwatcherConfig
{
    public int IdFtpwatcherConfig { get; set; }

    public int Instancia { get; set; }

    public string Host { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string? Ruta { get; set; }

    public string Acciones { get; set; } = null!;

    public bool Activo { get; set; }
}
