namespace RecordManagement.Domain.Entities;
    public class SkillsAndQualifications
    {
        public string Skill { get; }
        public string Language { get; }

        public SkillsAndQualifications(string skill, string language)
        {
            Skill = skill;
            Language = language;
        }
    }
