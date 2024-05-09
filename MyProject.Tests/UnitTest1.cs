using RecordManagement.Domain.ContactInformations;
using RecordManagement.Domain.EmploymentHistories;

using RecordManagement.Domain.PersonalInformations;

public class PersonalInformationTests
{
    [Fact]
    public void PersonalInformation_ConstructValidInstance()
    {
        // Arrange
        var fullName = "John Doe";
        var dateOfBirth = new DateTime(1990, 1, 1);
        var placeOfBirth = "Manila";
        var gender = "Male";
        var civilStatus = "Single";
        var citizenship = "Filipino";
        var height = 180;
        var weight = 75;
        var bloodType = "O+";

        // Act
        var personalInfo = new PersonalInformation(fullName, dateOfBirth, placeOfBirth, gender, civilStatus, citizenship, height, weight, bloodType);

        // Assert
        Assert.Equal(fullName, personalInfo.FullName);
        Assert.Equal(dateOfBirth, personalInfo.DateOfBirth);
        Assert.Equal(placeOfBirth, personalInfo.PlaceOfBirth);
        Assert.Equal(gender, personalInfo.Gender);
        Assert.Equal(civilStatus, personalInfo.CivilStatus);
        Assert.Equal(citizenship, personalInfo.Citizenship);
        Assert.Equal(height, personalInfo.Height);
        Assert.Equal(weight, personalInfo.Weight);
        Assert.Equal(bloodType, personalInfo.BloodType);
    }
     public class ContactInformationTests
    {
        [Fact]
        public void ContactInformation_ConstructValidInstance()
        {
            // Arrange
            var permanentAddress = "123 Main St, City";
            var presentAddress = "456 Oak Ave, Town";
            var phoneNumber = "123-456-7890";
            var mobileNumber = "987-654-3210";
            var emailAddress = "test@example.com";

            // Act
            var contactInfo = new ContactInformation(permanentAddress, presentAddress, phoneNumber, mobileNumber, emailAddress);

            // Assert
            Assert.Equal(permanentAddress, contactInfo.PermanentAddress);
            Assert.Equal(presentAddress, contactInfo.PresentAddress);
            Assert.Equal(phoneNumber, contactInfo.PhoneNumber);
            Assert.Equal(mobileNumber, contactInfo.MobileNumber);
            Assert.Equal(emailAddress, contactInfo.EmailAddress);
        }
    }

     [Fact]
        public void EmploymentHistory_ConstructValidInstance()
        {
            // Arrange
            var employer = "ABC Company";
            var position = "Software Engineer";
            var startDate = new DateTime(2020, 1, 1);
            var endDate = new DateTime(2022, 12, 31);

            // Act
            var employmentHistory = new EmploymentHistory(employer, position, startDate, endDate);

            // Assert
            Assert.Equal(employer, employmentHistory.Employer);
            Assert.Equal(position, employmentHistory.Position);
            Assert.Equal(startDate, employmentHistory.StartDate);
            Assert.Equal(endDate, employmentHistory.EndDate);
        }
    }


