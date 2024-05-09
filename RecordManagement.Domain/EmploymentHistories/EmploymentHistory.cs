using System.ComponentModel.DataAnnotations;

namespace RecordManagement.Domain.EmploymentHistories;
    public class EmploymentHistory
    {
        [Key]
    public Guid Id { get; set; }
    public Guid EmployeeId { get; set; }
    public string Employer { get; }
        public string Position { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }

        public EmploymentHistory(string employer, string position, DateTime startDate, DateTime endDate)
        {
            Employer = employer;
            Position = position;
            StartDate = startDate;
            EndDate = endDate;
        }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    private EmploymentHistory() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
}
