using Microsoft.EntityFrameworkCore;
using WorkFlowX.Server.Domain;

namespace WorkFlowX.Server.Application.Interfaces;

public interface IWorkOrderContext
{
    DbSet<WorkOrder> WorkOrders { get; }

    DbSet<Job> Jobs { get; }

    Task<Guid> SaveChangesAsync();
}