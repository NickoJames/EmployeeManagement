using Microsoft.EntityFrameworkCore;
using RecordManagement.Application.Common.Interfaces;
using RecordManagement.Contracts.DTOs;
using RecordManagement.Domain.Employees;
using RecordManagement.Domain.SkillsAndQualifications;
using RecordManagement.Infrastructure.Common.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordManagement.Infrastructure.Skills.Persistence
{
    public class AddskillReposistory : IAddSkillsRepository
    {

        private readonly EmployeeDbContext _dbContext;

        public AddskillReposistory(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddSkill(Guid employeeId, SkillsAndQualificationsDto skill)
        {
            var employee = await _dbContext.Employees.FindAsync(employeeId);
            if (employee != null)
            {
                employee.Skills.Add(new SkillsAndQualification
                (

                skill.Language,
                skill.Skill

                ));
            }
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Employee?> GetEmployeeById(Guid employeeId)
        {
            return await _dbContext.Employees.FirstOrDefaultAsync(Employee => Employee.Id == employeeId);

        }

        public Task SaveAsync()
        {

            return Task.CompletedTask;

        }
    }
}
