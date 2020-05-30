using System.Collections.Generic;

namespace locDemo.Repository.Employee
{
    public interface IEmployeeRepository
    {
        EmployeeEntity GetEmployee(int id);
        IEnumerable<EmployeeEntity> GetEmployees();
    }
}
