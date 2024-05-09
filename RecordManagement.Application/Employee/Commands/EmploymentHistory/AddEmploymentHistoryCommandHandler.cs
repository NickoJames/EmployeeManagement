using MediatR;
using RecordManagement.Application.Common.Interfaces;
using RecordManagement.Application.Employee.Commands.EducationalBackground;

namespace RecordManagement.Application.Employee.Commands.EmploymentHistory;

public class AddEmploymentHistoryCommandHandler : IRequestHandler<AddEmployementHistoryCommand , Domain.EmploymentHistories.EmploymentHistory>
{

    private readonly IEmployementHistoryRepository _employeeRepository;

    public AddEmploymentHistoryCommandHandler(IEmployementHistoryRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task<Domain.EmploymentHistories.EmploymentHistory> Handle(AddEmployementHistoryCommand command ,CancellationToken cancellationToken)
    {
        
        var employee = await _employeeRepository.GetEmployeeById(command.EmployeeId);
        if (employee == null)
        {
            throw new Exception($"Employee with ID {command.EmployeeId} not found.");
        }
 
        var employmentHistory = new Domain.EmploymentHistories.EmploymentHistory(
            command.Request.Employer,
            command.Request.Position,
            command.Request.StartDate,
            command.Request.EndDate ?? DateTime.MaxValue
        );
        
        
        await _employeeRepository.AddEmploymentHistory(command.EmployeeId ,command.Request);

         
        await _employeeRepository.SaveAsync();

       return employmentHistory;
    
    }

}