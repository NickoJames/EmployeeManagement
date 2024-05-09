using Microsoft.EntityFrameworkCore;
using RecordManagement.Application.Common.Interfaces;
using RecordManagement.Contracts.DTOs;
using RecordManagement.Domain.Employees;
using RecordManagement.Domain.EmploymentHistories;
using RecordManagement.Infrastructure.Common.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordManagement.Infrastructure.EmployementHistories.Persistence
{
    public class AddEmploymentHistoriesRepository : IEmployementHistoryRepository
    {


        private readonly EmployeeDbContext _dbContext; 
        public AddEmploymentHistoriesRepository (EmployeeDbContext dbContext)
        {
               _dbContext = dbContext;
        }
           


        public async Task AddEmploymentHistory(Guid employeeId, EmploymentHistoryDto employmentHistory)
        {
            var employee = await _dbContext.Employees.FindAsync(employeeId);
            if (employee != null)
            {
                employee.EmploymentHistories.Add(new EmploymentHistory
                (
                employmentHistory.Employer,
                employmentHistory.Position,
                employmentHistory.StartDate,
                employmentHistory.EndDate ?? DateTime.MinValue
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
