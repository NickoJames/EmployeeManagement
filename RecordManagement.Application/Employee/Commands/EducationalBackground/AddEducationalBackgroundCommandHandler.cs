namespace RecordManagement.Application.Employee.Commands.EducationalBackground;

using ErrorOr;
using MediatR;
using RecordManagement.Application.Common.Interfaces;
using System.Threading;
using System.Threading.Tasks;



public class AddEducationalBackgroundCommandHandler : IRequestHandler<AddEducationalBackgroundCommand, Domain.Educationalbackgrounds.EducationalBackground>
{
    private readonly IEducationalBackgroundRepository _employeeRepository;

    public AddEducationalBackgroundCommandHandler(IEducationalBackgroundRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }
    
    public async Task<Domain.Educationalbackgrounds.EducationalBackground> Handle(AddEducationalBackgroundCommand command, CancellationToken cancellationToken)
    {
        var employee = await _employeeRepository.GetEmployeeById(command.EmployeeId);
        if (employee is null)
        {
         
            throw new Exception($"Employee with ID {command.EmployeeId} not found.");
        }

        var educationalBackground = new Domain.Educationalbackgrounds.EducationalBackground(
            command.Request.Degree,
            command.Request.School,
            command.Request.YearGraduated
        );
        
        
      await _employeeRepository.AddEducationalBackground(command.EmployeeId ,command.Request);

      await _employeeRepository.SaveAsync();

       return educationalBackground;
    }

    
}
