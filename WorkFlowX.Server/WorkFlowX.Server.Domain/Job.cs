using System;

namespace WorkFlowX.Server.Domain;
public record Job : BaseEntity
{
    public long JobNumber { get; set; }

    public Guid WorkOrderId { get; set; }

    public WorkOrder WorkOrder { get; set; }

    public string Description { get; set; }

    public DateTimeOffset? TargetStartDate { get; set; }

    public DateTimeOffset? TargetCompletionDate { get; set; }

    public DateTimeOffset? AssignedOn { get; set; }

    public string AssignedTo { get; set; }
}