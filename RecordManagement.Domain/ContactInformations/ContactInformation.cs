using System.ComponentModel.DataAnnotations;
namespace RecordManagement.Domain.ContactInformations;



 public class ContactInformation
    {
        [Key]
        public Guid Id { get; set; }
       
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
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    private ContactInformation() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.




}



