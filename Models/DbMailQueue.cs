using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class DbMailQueue
{
    public int IdMailQueue { get; set; }

    public string? ProfileName { get; set; }

    public string? Recipients { get; set; }

    public string? CopyRecipients { get; set; }

    public string? BlindCopyRecipients { get; set; }

    public string? Subject { get; set; }

    public string? Body { get; set; }

    public string? BodyFormat { get; set; }

    public string? Importance { get; set; }

    public string? Sensitivity { get; set; }

    public string? FileAttachments { get; set; }

    public string? Query { get; set; }

    public string? ExecuteQueryDatabase { get; set; }

    public bool? AttachQueryResultAsFile { get; set; }

    public string? QueryAttachmentFilename { get; set; }

    public bool? QueryResultHeader { get; set; }

    public int? QueryResultWidth { get; set; }

    public string? QueryResultSeparator { get; set; }

    public bool? ExcludeQueryOutput { get; set; }

    public bool? AppendQueryError { get; set; }

    public bool? QueryNoTruncate { get; set; }

    public bool? QueryResultNoPadding { get; set; }

    public string? FromAddress { get; set; }

    public string? ReplyTo { get; set; }
}
