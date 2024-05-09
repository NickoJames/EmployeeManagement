using MediatR;
using RecordManagement.Contracts.DTOs;

namespace RecordManagement.Application.Employee.Commands.SkillsAndQualification;


public record AddSkillCommand(
    Guid EmployeeId,
    SkillsAndQualificationsDto Request) : IRequest<Domain.SkillsAndQualifications.SkillsAndQualification>;