using RecordManagement.Application.Common.Interfaces.Persistence;
using RecordManagement.Domain;

namespace RecordManagement.Infrastructure
{
    public class InMemoryEmployeeRepository : IEmployeeRepository
    {
        private static readonly List<Employee> _employees = new();

            public IEnumerable<Employee> GetAllEmployees()
        {
            return _employees;
        }

        public Employee? GetEmployeeById(Guid id)
        {
            return _employees.Find(employee => employee.Id == id) ;
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            var existingEmployee = _employees.FindIndex(e => e.Id == employee.Id);
            if (existingEmployee != -1)
            {
                _employees[existingEmployee] = employee;
            }
        }

        public void DeleteEmployee(Guid id)
        {
            var employeeToRemove = _employees.Find(employee => employee.Id == id);
            if (employeeToRemove != null)
            {
                _employees.Remove(employeeToRemove);
            }
        }

       
    }
}