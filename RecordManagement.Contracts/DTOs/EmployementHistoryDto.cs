namespace RecordManagement.Contracts.DTOs
{
    public class EmploymentHistoryDto
    {
        public string Employer { get; set; }= null!;
        public string Position { get; set; }= null!;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
