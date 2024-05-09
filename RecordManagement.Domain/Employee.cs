namespace RecordManagement.Domain;
 

using RecordManagement.Domain.Entities;

public class Employee
    {
        public Guid Id { get; } 
        public PersonalInformation PersonalInfo { get; }
        public ContactInformation ContactInfo { get; }
        public List<EducationalBackground> EducationalBackgrounds { get; } = new List<EducationalBackground>();
        public List<EmploymentHistory> EmploymentHistories { get; } = new List<EmploymentHistory>();
        public List<SkillsAndQualifications> Skills { get; } = new List<SkillsAndQualifications>();
        public List<Reference> References { get; } = new List<Reference>();

        public Employee(Guid uniqueId,PersonalInformation personalInfo, ContactInformation contactInfo)
        
        {
           Id = uniqueId;
            PersonalInfo = personalInfo;
            ContactInfo = contactInfo;
        }

        public void AddEducationalBackground(EducationalBackground educationalBackground)
        {
            EducationalBackgrounds.Add(educationalBackground);
        }

        public void AddEmploymentHistory(EmploymentHistory employmentHistory)
        {
            EmploymentHistories.Add(employmentHistory);
        }

        public void AddSkill(SkillsAndQualifications skill)
        {
            Skills.Add(skill);
        }

        public void AddReference(Reference reference)
        {
            References.Add(reference);
        }
    }
