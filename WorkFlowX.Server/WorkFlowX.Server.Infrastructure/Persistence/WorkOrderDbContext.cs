using Microsoft.EntityFrameworkCore;
using WorkFlowX.Server.Application.Interfaces;
using WorkFlowX.Server.Domain;

namespace WorkFlowX.Server.Infrastructure.Persistence;

public class WorkOrderDbContext : DbContext, IWorkOrderContext
{
    public DbSet<WorkOrder> WorkOrders { get; set; }

    public DbSet<Job> Jobs { get; set; }

    public Task<Guid> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}
