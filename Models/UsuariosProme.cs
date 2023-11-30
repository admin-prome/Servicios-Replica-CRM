using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class UsuariosProme
{
    public string? Legajo { get; set; }

    public string? FullName { get; set; }

    public string? InternalEmailAddress { get; set; }

    public string? DomainName { get; set; }

    public bool? IsDisabled { get; set; }

    public int? Caltype { get; set; }
}
