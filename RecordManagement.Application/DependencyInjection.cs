
using Microsoft.Extensions.DependencyInjection;
using RecordManagement.Application.Services;

namespace RecordManagement.Application;

public static class DependencyInjection{

    public static IServiceCollection AddApplication(this IServiceCollection services)
    {

            services.AddScoped<IEmployeeService , EmployeeService>();
            
            return services;


    }

}