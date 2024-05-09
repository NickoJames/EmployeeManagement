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
    public interface IAddSkillsRepository
    {
        Task AddSkill(Guid employeeId, SkillsAndQualificationsDto skill);
        Task<Employees?> GetEmployeeById(Guid id);
        Task SaveAsync();
    }
}
