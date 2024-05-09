

namespace RecordManagement.Contracts.EmployeeRequest;
   
    public record CreateEmployeeRequest
    (
     
      string FullName,
         DateTime DateOfBirth,
        string PlaceOfBirth ,
        string Gender ,
       string CivilStatus ,
        string Citizenship ,
       int Height ,
      int Weight,
        string BloodType ,
        string PermanentAddress ,
     string PresentAddress ,
       string PhoneNumber ,
        string MobileNumber ,
    string EmailAddress , string Password
  );
