using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class OwnerBase
{
    public int? OwnerIdType { get; set; }

    public Guid? OwnerId { get; set; }

    public string? Name { get; set; }

    public byte[]? VersionNumber { get; set; }

    public string? YomiName { get; set; }
}
