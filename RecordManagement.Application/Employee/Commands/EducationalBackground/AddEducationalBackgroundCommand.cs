using MediatR;
using RecordManagement.Contracts.DTOs;

namespace RecordManagement.Application.Employee.Commands.EducationalBackground;

public record AddEducationalBackgroundCommand(
Guid EmployeeId, 
EducationalBackgroundDto Request) :
 IRequest<Domain.Educationalbackgrounds.EducationalBackground>;
