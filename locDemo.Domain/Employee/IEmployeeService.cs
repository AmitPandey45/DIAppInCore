using System.Collections.Generic;

namespace locDemo.Domain.Employee
{
    public interface IEmployeeService
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetEmployees();
    }
}
