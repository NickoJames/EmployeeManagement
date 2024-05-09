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
    public interface IAddReferencesRepository
    {
        Task AddReference(Guid employeeId, ReferenceDto reference);
        Task<Employees?> GetEmployeeById(Guid id);
        Task SaveAsync();

    }
}
