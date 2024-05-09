using MediatR;
using RecordManagement.Application.Common.Interfaces;

namespace RecordManagement.Application.Employee.Commands.SkillsAndQualification;

public class AddSkillCommandHandler : IRequestHandler<AddSkillCommand, Domain.SkillsAndQualifications.SkillsAndQualification>
{

        private readonly IAddSkillsRepository _employeeRepository;

    public AddSkillCommandHandler(IAddSkillsRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task<Domain.SkillsAndQualifications.SkillsAndQualification> Handle(AddSkillCommand command ,CancellationToken cancellationToken)
    {
        var employee = await _employeeRepository.GetEmployeeById(command.EmployeeId);
        if (employee == null)
        {
            throw new Exception($"Employee with ID {command.EmployeeId} not found.");
        }
 

        var employmentHistory = new Domain.SkillsAndQualifications.SkillsAndQualification(
            command.Request.Skill,
            command.Request.Language
            );
        
        
        
        await _employeeRepository.AddSkill(command.EmployeeId ,command.Request);
        await _employeeRepository.SaveAsync();

       return employmentHistory;

    }


}

