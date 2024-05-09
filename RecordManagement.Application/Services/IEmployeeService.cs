using System.Xml;
using RecordManagement.Domain;
using RecordManagement.Domain.Entities;

namespace RecordManagement.Application.Services;

    public interface IEmployeeService
    {
        Employee CreateEmployee(Guid UniqueId,PersonalInformation personalInfo, ContactInformation contactInfo);
        void AddEducationalBackground(Employee employee, EducationalBackground educationalBackground);
        void AddEmploymentHistory(Employee employee, EmploymentHistory employmentHistory);
        void AddSkill(Employee employee, SkillsAndQualifications skill);
        void AddReference(Employee employee, Reference reference);
   
}
