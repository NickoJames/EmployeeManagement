using MediatR;
using RecordManagement.Contracts.DTOs;

namespace RecordManagement.Application.Employee.Commands.Reference;

public record AddReferenceCommand (
    Guid EmployeeId,
    ReferenceDto Request) : IRequest<Domain.References.Reference>;