namespace RecordManagement.Domain.Employees;

using System.ComponentModel.DataAnnotations;
using RecordManagement.Domain.ContactInformations;
using RecordManagement.Domain.Educationalbackgrounds;
using RecordManagement.Domain.EmploymentHistories;

using RecordManagement.Domain.PersonalInformations;
using RecordManagement.Domain.References;
using RecordManagement.Domain.SkillsAndQualifications;

public sealed class Employee
    {
        [Key]
        public Guid Id { get; private set;}
        public PersonalInformation PersonalInfo { get; private set; }
        public ContactInformation ContactInfo { get; private set;}
        public List<EducationalBackground> EducationalBackgrounds { get; private set;} = new List<EducationalBackground>();
        public List<EmploymentHistory> EmploymentHistories { get; private set;} = new List<EmploymentHistory>();
        public List<SkillsAndQualification> Skills { get;private set; } = new List<SkillsAndQualification>();
        public List<Reference> References { get; private set;} = new List<Reference>();

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    private Employee() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
   
    
    public Employee(
            Guid uniqueId,
            PersonalInformation personalInfo, 
            ContactInformation contactInfo)
        
        {
           Id = uniqueId;
            PersonalInfo = personalInfo;
            ContactInfo = contactInfo;
        }


    
        public static Employee CreateEmployee(
            Guid uniqueId,
            PersonalInformation personalInfo,
            ContactInformation contactInfo,
            List<Employee> existingEmployees)
        {
            if (existingEmployees.Any(e => e.PersonalInfo.FullName.Equals(personalInfo.FullName, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException($"An employee with the name {personalInfo.FullName} already exists.");
            }
            return new Employee(uniqueId, personalInfo, contactInfo);
        }
    


}
