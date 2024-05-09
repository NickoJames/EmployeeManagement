
using Microsoft.Extensions.DependencyInjection;
using RecordManagement.Application.Common.Interfaces.Persistence;
using RecordManagement.Infrastructure;



namespace RecordManagement.Application;

public static class DependencyInjection{

    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
    
          services.AddScoped<IEmployeeRepository, InMemoryEmployeeRepository>();
            return services;


    }

}