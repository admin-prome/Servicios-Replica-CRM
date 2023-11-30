using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class MetadataSchemaLocalizedLabel
{
    public Guid? LocalizedLabelId { get; set; }

    public Guid? LocalizedLabelRowId { get; set; }

    public int? LanguageId { get; set; }

    public Guid? ObjectId { get; set; }

    public string? ObjectColumnName { get; set; }

    public string? Label { get; set; }

    public byte[]? VersionNumber { get; set; }

    public int? LabelTypeCode { get; set; }

    public Guid? SolutionId { get; set; }

    public Guid? SupportingSolutionId { get; set; }

    public byte? ComponentState { get; set; }

    public DateTime? OverwriteTime { get; set; }

    public bool? IsManaged { get; set; }
}
