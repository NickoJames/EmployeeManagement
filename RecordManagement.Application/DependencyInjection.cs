
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RecordManagement.Application.Employee.Commands.CreateEmployee;
using RecordManagement.Application.Employee.Commands.EducationalBackground;
using RecordManagement.Domain.Educationalbackgrounds;



namespace RecordManagement.Application;

public static class DependencyInjection{

    public static IServiceCollection AddApplication(this IServiceCollection services)
    {

            services.AddMediatR(options =>
            {
                options.RegisterServicesFromAssemblyContaining(typeof(DependencyInjection));
                services.AddTransient<IRequestHandler<CreateEmployeeCommand, Domain.Employees.Employee>, CreateEmployeeCommandHandler>();
                services.AddTransient<IRequestHandler<AddEducationalBackgroundCommand, EducationalBackground>, AddEducationalBackgroundCommandHandler>();
                
                });
                
            
            return services;


    }
    
}