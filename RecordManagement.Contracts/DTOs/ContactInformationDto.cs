namespace RecordManagement.Contracts.DTOs
{
    public class ContactInformationDto
    {
        public string PermanentAddress { get; set; } = null!;
        public string PresentAddress { get; set; }= null!;
        public string PhoneNumber { get; set; }= null!;
        public string MobileNumber { get; set; }= null!;
        public string EmailAddress { get; set; }= null!;
    }
}
