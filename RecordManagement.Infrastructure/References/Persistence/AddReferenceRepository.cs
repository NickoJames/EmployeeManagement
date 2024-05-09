using Microsoft.EntityFrameworkCore;
using RecordManagement.Application.Common.Interfaces;
using RecordManagement.Contracts.DTOs;
using RecordManagement.Domain.Employees;
using RecordManagement.Domain.References;
using RecordManagement.Infrastructure.Common.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordManagement.Infrastructure.References.Persistence
{
    internal class AddReferenceRepository : IAddReferencesRepository
    {
        private readonly EmployeeDbContext _dbContext;

        public AddReferenceRepository(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddReference(Guid employeeId, ReferenceDto reference)
        {
            var employee = await _dbContext.Employees.FindAsync(employeeId);
            if (employee != null)
            {
                employee.References.Add(new Reference
                (

             reference.Name,
             reference.ContactInformation

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

