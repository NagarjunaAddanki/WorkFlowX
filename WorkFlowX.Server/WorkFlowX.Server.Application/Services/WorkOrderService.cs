using Microsoft.EntityFrameworkCore;
using WorkFlowX.Server.Application.Interfaces;
using WorkFlowX.Server.Domain;

namespace WorkFlowX.Server.Application.Services;

public class WorkOrderService : IWorkOrderService
{
    private IWorkOrderContext WorkOrderContext { get; }

    public WorkOrderService(IWorkOrderContext workOrderContext) => 
    (WorkOrderContext) = (workOrderContext);


    public async Task<List<Job>> GetJobsAsync() =>
    await WorkOrderContext.Jobs.AsNoTracking().ToListAsync();
}