using System;

namespace WorkFlowX.Server.Domain;
public record WorkOrder : BaseEntity
{
    public long WorkOrderNumber { get; set; }

    public string Description { get; set; }

    public string OwnedBy { get; set; }

    public string Address { get; set; }

    public WorkOrderPriority Priority { get; set; }    

    public DateTimeOffset TargetStartDate { get; set; }

    public DateTimeOffset TargetEndDate { get; set; }

    public List<Job> Jobs { get; set; }
}