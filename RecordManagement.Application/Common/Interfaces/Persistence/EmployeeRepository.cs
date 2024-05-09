using RecordManagement.Domain;

namespace RecordManagement.Application.Common.Interfaces.Persistence;

public interface IEmployeeRepository 
{
    Employee GetEmployeeById (Guid id);

    void AddEmployee(Employee employee);

    void DeleteEmployee(Guid id);
    void UpdateEmployee(Employee employee);
    IEnumerable<Employee> GetAllEmployees();

}
