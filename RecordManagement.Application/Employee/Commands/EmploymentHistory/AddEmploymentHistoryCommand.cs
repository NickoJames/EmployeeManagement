using MediatR;
using RecordManagement.Contracts.DTOs;


namespace RecordManagement.Application.Employee.Commands.EducationalBackground;

public record AddEmployementHistoryCommand(
Guid EmployeeId, 
EmploymentHistoryDto Request) :
 IRequest<Domain.EmploymentHistories.EmploymentHistory>;