namespace RecordManagement.Domain.Entities;
    public class EmploymentHistory
    {
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
    }