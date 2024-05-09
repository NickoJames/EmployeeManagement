namespace RecordManagement.Domain.Entities;
    public class EducationalBackground
    {

        
        public string Degree { get; }
        public string School { get; }
        public int YearGraduated { get; }

        public EducationalBackground(string degree, string school, int yearGraduated)
        {
            Degree = degree;
            School = school;
            YearGraduated = yearGraduated;
        }
    }
