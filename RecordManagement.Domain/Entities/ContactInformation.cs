namespace RecordManagement.Domain.Entities;



 public class ContactInformation
    {
        public string PermanentAddress { get; }
        public string PresentAddress { get; }
        public string PhoneNumber { get; }
        public string MobileNumber { get; }
        public string EmailAddress { get; }

        public ContactInformation(string permanentAddress, string presentAddress, string phoneNumber, string mobileNumber, string emailAddress)
        {
            PermanentAddress = permanentAddress;
            PresentAddress = presentAddress;
            PhoneNumber = phoneNumber;
            MobileNumber = mobileNumber;
            EmailAddress = emailAddress;
        }
    }
