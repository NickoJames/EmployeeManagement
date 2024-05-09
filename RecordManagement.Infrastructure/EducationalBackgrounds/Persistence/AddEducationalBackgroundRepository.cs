using Microsoft.EntityFrameworkCore;
using RecordManagement.Application.Common.Interfaces;
using RecordManagement.Contracts.DTOs;
using RecordManagement.Domain.Educationalbackgrounds;
using RecordManagement.Domain.Employees;
using RecordManagement.Infrastructure.Common.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordManagement.Infrastructure.EducationalBackgrounds.Persistence
{
    public class AddEducationalBackgroundRepository : IEducationalBackgroundRepository
    {
        private readonly EmployeeDbContext _dbContext;
        public AddEducationalBackgroundRepository(EmployeeDbContext dbContext)
        {

            _dbContext = dbContext;
        }


        public async Task AddEducationalBackground(Guid employeeId, EducationalBackgroundDto educationalBackground)
        {
            var employee = await _dbContext.Employees
                                           .Include(e => e.EducationalBackgrounds)
                                           .FirstOrDefaultAsync(e => e.Id == employeeId);

            if (employee is null)
            {
                throw new Exception("Employee not found.");
            }

            employee.EducationalBackgrounds.Add(new EducationalBackground(

              educationalBackground.Degree,
              educationalBackground.School,
              educationalBackground.YearGraduated
          ));

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
