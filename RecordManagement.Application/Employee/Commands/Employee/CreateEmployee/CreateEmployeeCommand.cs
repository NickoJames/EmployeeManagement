using MediatR;
using RecordManagement.Contracts.DTOs;
using RecordManagement.Domain;




namespace RecordManagement.Application.Employee.Commands.CreateEmployee;
public record CreateEmployeeCommand(
    Guid UniqueId, CreateEmployeeRequest Request) : IRequest<Domain.Employees.Employee>;
