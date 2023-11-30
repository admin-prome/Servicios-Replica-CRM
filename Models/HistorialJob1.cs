using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class HistorialJob1
{
    public string? Server { get; set; }

    public long? InstanceId { get; set; }

    public int? SqlMessageId { get; set; }

    public string? Message { get; set; }

    public int? StepId { get; set; }

    public string? StepName { get; set; }

    public int? SqlSeverity { get; set; }

    public Guid? JobId { get; set; }

    public string? JobName { get; set; }

    public int? RunStatus { get; set; }

    public string RunStatusDesc { get; set; } = null!;

    public DateTime? RunDate { get; set; }

    public int? RunDuration { get; set; }

    public int? RunDurationMinutes { get; set; }

    public string? OperatorEmailed { get; set; }

    public string? OperatorNetsent { get; set; }

    public string? OperatorPaged { get; set; }

    public int? RetriesAttempted { get; set; }

    public DateTime FechaProceso { get; set; }

    public string? IdProceso { get; set; }
}
