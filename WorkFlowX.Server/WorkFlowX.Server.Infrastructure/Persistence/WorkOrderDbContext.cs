using Microsoft.EntityFrameworkCore;
using WorkFlowX.Server.Application.Interfaces;
using WorkFlowX.Server.Domain;

namespace WorkFlowX.Server.Infrastructure.Persistence;

public class WorkOrderDbContext : DbContext, IWorkOrderContext
{
    public WorkOrderDbContext(DbContextOptions<WorkOrderDbContext> options)
         : base(options)
        {
        }

    public DbSet<WorkOrder> WorkOrders { get; set; }

    public DbSet<Job> Jobs { get; set; }

    public Task<Guid> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}
