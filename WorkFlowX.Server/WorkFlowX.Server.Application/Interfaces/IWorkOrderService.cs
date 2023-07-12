using WorkFlowX.Server.Domain;

namespace WorkFlowX.Server.Application.Interfaces;

public interface IWorkOrderService
{
    Task<List<Job>> GetJobsAsync();
}