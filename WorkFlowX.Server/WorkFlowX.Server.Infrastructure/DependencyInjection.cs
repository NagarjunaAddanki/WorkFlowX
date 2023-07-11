using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WorkFlowX.Server.Application.Interfaces;
using WorkFlowX.Server.Infrastructure.Persistence;

namespace WorkFlowX.Server.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<WorkOrderDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("WorkFlowX"), b => b.MigrationsAssembly(typeof(WorkOrderDbContext).Assembly.FullName)), ServiceLifetime.Transient);

        services.AddScoped<IWorkOrderContext, WorkOrderDbContext>();
        return services;
    }
}
