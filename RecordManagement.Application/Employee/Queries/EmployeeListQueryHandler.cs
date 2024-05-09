using MediatR;
using RecordManagement.Application.Common.Interfaces;
using RecordManagement.Contracts.DTOs;

namespace RecordManagement.Application.Employee.Queries;

public class EmployeeListQueryHandler : IRequestHandler<EmployeeListQuery, IEnumerable<Domain.Employees.Employee>>
{               
    private readonly IEmployeeRepository1 _employeeRepository;

    public EmployeeListQueryHandler(IEmployeeRepository1 employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task<IEnumerable<Domain.Employees.Employee>> Handle(EmployeeListQuery request, CancellationToken cancellationToken)
    {
        var Id = request.UniqueId;
        return await _employeeRepository.EmployeeListAsync(Id);
    }
}