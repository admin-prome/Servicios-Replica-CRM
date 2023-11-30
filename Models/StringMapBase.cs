using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class StringMapBase
{
    public int? ObjectTypeCode { get; set; }

    public string? AttributeName { get; set; }

    public int? AttributeValue { get; set; }

    public int? LangId { get; set; }

    public Guid? OrganizationId { get; set; }

    public string? Value { get; set; }

    public int? DisplayOrder { get; set; }

    public byte[]? VersionNumber { get; set; }

    public Guid? StringMapId { get; set; }
}
