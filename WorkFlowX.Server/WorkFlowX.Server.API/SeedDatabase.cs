using Bogus;
using WorkFlowX.Server.Application.Interfaces;
using WorkFlowX.Server.Domain;

namespace WorkFlowX.Server.Api;

public static class SeedDatabase
{
    public static async Task Seed(this WebApplication webApp)
    {
        using (var scope = webApp.Services.CreateScope())
        {
            var appContext = scope.ServiceProvider.GetRequiredService<IWorkOrderContext>();
            try
            {
                if(!appContext.WorkOrders.Any()){
                    await appContext.WorkOrders.AddRangeAsync(woFaker.Generate(10));
                    await appContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                //Log errors or do anything you think it's needed
                Console.WriteLine(ex.Message);
            }            
        }
    }

    private static Faker<WorkOrder> woFaker = new Faker<WorkOrder>()
    .RuleFor(u => u.Id, (f, u) => Guid.NewGuid())
    .RuleFor(u => u.WorkOrderNumber, (f, u) => f.UniqueIndex)
    .RuleFor(u => u.Address, (f, u) => f.Address.FullAddress())
    .RuleFor(u => u.CreatedBy, (f, u) => f.Name.FullName())
    .RuleFor(u => u.CreatedOn, (f, u) => f.Date.PastOffset())
    .RuleFor(u => u.Description, (f, u) => f.Lorem.Lines())
    .RuleFor(u => u.OwnedBy, (f, u) => f.Name.FullName())
    .RuleFor(u => u.Priority, (f, u) => f.Random.Enum<WorkOrderPriority>())
    .RuleFor(u => u.TargetStartDate, (f, u) => f.Date.FutureOffset())
    .RuleFor(u => u.TargetEndDate, (f, u) => f.Date.FutureOffset())
    .RuleFor(u => u.UpdatedOn, (f, u) => f.Date.PastOffset())
    .RuleFor(u => u.Jobs, (_,e) => GetBogusJobs(e.Id));

    private static Faker<Job> jobFaker = new Faker<Job>()
    .RuleFor(u => u.Id, (f, u) => Guid.NewGuid())
    .RuleFor(u => u.JobNumber, (f, u) => f.UniqueIndex)
    .RuleFor(u => u.WorkOrderId, (f, u) => Guid.NewGuid())
    .RuleFor(u => u.CreatedBy, (f, u) => f.Name.FullName())
    .RuleFor(u => u.CreatedOn, (f, u) => f.Date.PastOffset())
    .RuleFor(u => u.AssignedTo, (f, u) => f.Name.FullName())
    .RuleFor(u => u.AssignedOn, (f, u) => f.Date.PastOffset())
    .RuleFor(u => u.Description, (f, u) => f.Lorem.Sentence())
    .RuleFor(u => u.TargetStartDate, (f, u) => f.Date.FutureOffset())
    .RuleFor(u => u.TargetCompletionDate, (f, u) => f.Date.FutureOffset())
    .RuleFor(u => u.TargetCompletionDate, (f, u) => f.Date.PastOffset());

    private static List<Job> GetBogusJobs(Guid woId)
    {
        var jobs = jobFaker.Generate(10);
        jobs.ForEach(j => j.WorkOrderId = woId);
        return jobs;
    }
}