using System.ComponentModel.DataAnnotations;

namespace RecordManagement.Domain.Educationalbackgrounds;
    public class EducationalBackground
    {

        [Key]

        public Guid Id { get; set; }
         public Guid EmployeeId { get; set; }
        public string Degree { get; private set; }
        public string School { get; private set;}
        public int YearGraduated { get;private set; }

        public EducationalBackground(string degree, string school, int yearGraduated)
        {
          
            Degree = degree;
            School = school;
            YearGraduated = yearGraduated;
        }



        

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    public EducationalBackground() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.




}
