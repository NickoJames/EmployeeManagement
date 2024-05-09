namespace RecordManagement.Contracts.EmployeeRequest;

public record AddEducationalBackground(
    int id ,
    string Degree, 
    string School, 
    int YearGraduated
);