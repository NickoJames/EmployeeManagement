using MediatR;
using RecordManagement.Application.Common.Interfaces;
using RecordManagement.Domain.ContactInformations;
using RecordManagement.Domain.PersonalInformations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RecordManagement.Application.Employee.Commands.CreateEmployee
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, Domain.Employees.Employee>
    {
        private readonly IEmployeeRepository1 _employeeRepository1;

        public CreateEmployeeCommandHandler(IEmployeeRepository1 employeeRepository1)
        {
            _employeeRepository1 = employeeRepository1;
        }

        public async Task<Domain.Employees.Employee> Handle(CreateEmployeeCommand command, CancellationToken cancellationToken)
        {
            // Retrieve existing employees
            var existingEmployees = await _employeeRepository1.GetAllEmployees();

            // Create the personal information object
            var personalInfo = new PersonalInformation(
                command.Request.PersonalInformation.FullName,
                command.Request.PersonalInformation.DateOfBirth,
                command.Request.PersonalInformation.PlaceOfBirth,
                command.Request.PersonalInformation.Gender,
                command.Request.PersonalInformation.CivilStatus,
                command.Request.PersonalInformation.Citizenship,
                command.Request.PersonalInformation.Height,
                command.Request.PersonalInformation.Weight,
                command.Request.PersonalInformation.BloodType
            );

            // Create the contact information object
            var contactInfo = new ContactInformation(
                command.Request.ContactInformation.PermanentAddress,
                command.Request.ContactInformation.PresentAddress,
                command.Request.ContactInformation.PhoneNumber,
                command.Request.ContactInformation.MobileNumber,
                command.Request.ContactInformation.EmailAddress
            );

            // Check if an employee with the same full name already exists
            if (existingEmployees.Any(e => e.PersonalInfo.FullName.Equals(personalInfo.FullName, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException($"An employee with the name {personalInfo.FullName} already exists.");
            }

            // Create a new employee
            var employee = new Domain.Employees.Employee(command.UniqueId, personalInfo, contactInfo);

            // Persist the new employee
            await _employeeRepository1.CreateEmployee(employee);

            return employee;
        }
    }
}
