
using System.ComponentModel.DataAnnotations;
namespace RecordManagement.Domain.PersonalInformations;
 public class PersonalInformation
    { 
    public Guid Id { get; set; }
        public string FullName { get; }
        public DateTime DateOfBirth { get; }
        public string PlaceOfBirth { get; }
        public string Gender { get; }
        public string CivilStatus { get; }
        public string Citizenship { get; }
        public int Height { get; }
        public int Weight { get; }
        public string BloodType { get; }

        public PersonalInformation(string fullName, DateTime dateOfBirth, string placeOfBirth, string gender, string civilStatus, string citizenship, int height, int weight, string bloodType)
        {
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            PlaceOfBirth = placeOfBirth;
            Gender = gender;
            CivilStatus = civilStatus;
            Citizenship = citizenship;
            Height = height;
            Weight = weight;
            BloodType = bloodType;
        }
          private PersonalInformation() { }
    }
