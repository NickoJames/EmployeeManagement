using MediatR;
using RecordManagement.Application.Common.Interfaces;

namespace RecordManagement.Application.Employee.Commands.Reference;

public class AddReferenceCommandHandler : IRequestHandler<AddReferenceCommand , Domain.References.Reference>
{
    private readonly IAddReferencesRepository _employeeRepository;

    public AddReferenceCommandHandler(IAddReferencesRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

        public async Task<Domain.References.Reference> Handle(AddReferenceCommand command, CancellationToken cancellationToken)
        {

        var employee = await _employeeRepository.GetEmployeeById(command.EmployeeId);
        if (employee == null)
        {
            throw new Exception($"Employee with ID {command.EmployeeId} not found.");
        }
 
        var employmentHistory = new Domain.References.Reference(
          
            

            command.Request.Name,
            command.Request.ContactInformation
            
        );
        
        
        await _employeeRepository.AddReference(command.EmployeeId ,command.Request);

           
        await _employeeRepository.SaveAsync();

       return employmentHistory;

        }

}