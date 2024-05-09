using RecordManagement.Contracts.DTOs;
using RecordManagement.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees = RecordManagement.Domain.Employees.Employee;

namespace RecordManagement.Application.Common.Interfaces
{
    public interface IEmployeeRepository1
    {

        Task<Employees> CreateEmployee(Guid uniqueId, CreateEmployeeRequest request);
        Task DeleteEmployee(Guid employeeId);
        Task<IEnumerable<Employees?>> EmployeeListAsync(Guid employeeId);


    }
}
