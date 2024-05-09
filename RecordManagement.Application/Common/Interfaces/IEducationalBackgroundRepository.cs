using RecordManagement.Contracts.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees = RecordManagement.Domain.Employees.Employee;

namespace RecordManagement.Application.Common.Interfaces
{
    public interface IEducationalBackgroundRepository
    {
        Task AddEducationalBackground(Guid employeeId, EducationalBackgroundDto educationalBackground);
        Task<Employees?> GetEmployeeById(Guid id);
        Task SaveAsync();

    }
}
