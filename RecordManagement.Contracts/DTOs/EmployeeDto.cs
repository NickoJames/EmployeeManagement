namespace RecordManagement.Contracts.DTOs
{
    public class EmployeeDto
    {
        public Guid Id { get; set; }
        public PersonalInformationDto PersonalInfo { get; set; }= null!;
        public ContactInformationDto ContactInfo { get; set; }= null!;
        public List<EducationalBackgroundDto> EducationalBackgrounds { get; set; } = new List<EducationalBackgroundDto>();
        public List<EmploymentHistoryDto> EmploymentHistories { get; set; } = new List<EmploymentHistoryDto>();
        public List<SkillsAndQualificationsDto> Skills { get; set; } = new List<SkillsAndQualificationsDto>();
        public List<ReferenceDto> References { get; set; } = new List<ReferenceDto>();
    }
}
