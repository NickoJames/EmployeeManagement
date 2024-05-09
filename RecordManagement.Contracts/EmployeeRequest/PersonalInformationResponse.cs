namespace RecordManagement.Contracts.EmployeeRequest;

    public class PersonalInformationResponse
    {
        public string FullName { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }= null!;
        public string Gender { get; set; }= null!;
        public string CivilStatus { get; set; }= null!;
        public string Citizenship { get; set; }= null!;
        public int Height { get; set; }
        public int Weight { get; set; }
        public string BloodType { get; set; }= null!;
    }



