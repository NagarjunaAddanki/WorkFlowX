using System;

namespace WorkFlowX.Server.Domain;

public record BaseEntity
{
    public Guid Id { get; set; }

    public DateTimeOffset CreatedOn { get; set; }

    public string CreatedBy { get; set; }

    public DateTimeOffset UpdatedOn { get; set; }
}