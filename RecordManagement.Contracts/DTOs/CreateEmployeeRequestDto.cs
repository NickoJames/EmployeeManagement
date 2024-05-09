
namespace RecordManagement.Contracts.DTOs
{
    public class CreateEmployeeRequest
    {
        public PersonalInformationDto PersonalInformation { get; set; } = null!;
        public ContactInformationDto ContactInformation { get; set; } = null!;
        
    }
}