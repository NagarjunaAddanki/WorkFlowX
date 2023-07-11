using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkFlowX.Server.Application.Interfaces;
using WorkFlowX.Server.Application.Services;

namespace WorkFlowX.Server.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IWorkOrderService, WorkOrderService>();
        return services;
    }
}
