

using RecordManagement.Domain;
using RecordManagement.Domain.Entities;
namespace RecordManagement.Application.Services;
public class EmployeeService : IEmployeeService
    {
        public Employee CreateEmployee(
            Guid uniqueId,
            PersonalInformation 
            personalInfo, 
            ContactInformation 
            contactInfo)
        {
            return new Employee(uniqueId,personalInfo, contactInfo);
        }

        public void AddEducationalBackground(Employee employee, EducationalBackground educationalBackground)
        {
            employee.AddEducationalBackground(educationalBackground);
        }

        public void AddEmploymentHistory(Employee employee, EmploymentHistory employmentHistory)
        {
            employee.AddEmploymentHistory(employmentHistory);
        }

        public void AddSkill(Employee employee, SkillsAndQualifications skill)
        {
            employee.AddSkill(skill);
        }

        public void AddReference(Employee employee, Reference reference)
        {
            employee.AddReference(reference);
        }

   
}