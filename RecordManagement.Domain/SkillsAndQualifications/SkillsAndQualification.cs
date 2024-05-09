using System.ComponentModel.DataAnnotations;

namespace RecordManagement.Domain.SkillsAndQualifications;
public class SkillsAndQualification
{
    [Key]
    public Guid Id { get; set; }
    public Guid EmployeeId { get; set; }
    public string Skill { get; }
    public string Language { get; }

    public SkillsAndQualification
    (string skill,
    string language)

    {
        Skill = skill;
        Language = language;
    }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    private SkillsAndQualification() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
}
