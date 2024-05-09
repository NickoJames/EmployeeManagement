using Microsoft.EntityFrameworkCore;
using RecordManagement.Application.Common.Interfaces;
using RecordManagement.Contracts.DTOs;
using RecordManagement.Domain.ContactInformations;
using RecordManagement.Domain.Employees;
using RecordManagement.Domain.PersonalInformations;
using RecordManagement.Infrastructure.Common.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordManagement.Infrastructure.Employees.Persistence
{
    public class EmployeeRepository : IEmployeeRepository1
    {
        private readonly EmployeeDbContext _dbContext;

        public EmployeeRepository(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Employee> CreateEmployee(Guid uniqueId, CreateEmployeeRequest request)
        {
            var personalInfo = new PersonalInformation(
               request.PersonalInformation.FullName,
               request.PersonalInformation.DateOfBirth,
               request.PersonalInformation.PlaceOfBirth,
               request.PersonalInformation.Gender,
               request.PersonalInformation.CivilStatus,
               request.PersonalInformation.Citizenship,
               request.PersonalInformation.Height,
               request.PersonalInformation.Weight,
               request.PersonalInformation.BloodType
           );

            var contactInfo = new ContactInformation(
                request.ContactInformation.PermanentAddress,
                request.ContactInformation.PresentAddress,
                request.ContactInformation.PhoneNumber,
                request.ContactInformation.MobileNumber,
                request.ContactInformation.EmailAddress
            );

            var employee = new Employee(uniqueId, personalInfo, contactInfo);
            _dbContext.Employees.Add(employee);

            var employeeDto = new EmployeeDto
            {
                Id = employee.Id,
                PersonalInfo = request.PersonalInformation,
                ContactInfo = request.ContactInformation


            };
            await _dbContext.SaveChangesAsync();
            return employee;
        }
        async public Task DeleteEmployee(Guid UniqueId)
        {
            var employee = await _dbContext.Employees.FindAsync(UniqueId);



            if (employee != null)
            {
                 _dbContext.Remove(employee);
                await _dbContext.SaveChangesAsync();
            }



        }


        public Task CreateEmployee(Employee employee)
        {
            _dbContext.Add(employee);
            return Task.CompletedTask;
        }

        //Queries


        public async Task<IEnumerable<Employee>> EmployeeListAsync(Guid employeeId)
        {
            var employee = await _dbContext.Employees
         .Include(e => e.EducationalBackgrounds)
         .Include(e => e.EmploymentHistories)
         .Include(e => e.Skills)
         .Include(e => e.References)
         .ToListAsync();

            if (employee == null)
            {
                throw new Exception("Employee not found.");
            }

            return employee;
        }

    }
}
