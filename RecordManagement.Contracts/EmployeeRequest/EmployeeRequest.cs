

namespace RecordManagement.Contracts.EmployeeRequest
{
    public class CreateEmployeeResponse
    {
        public PersonalInformationResponse PersonalInformation { get; set; } = null!;
        public ContactInformationResponse ContactInformation { get; set; } = null!;
        
    }
}