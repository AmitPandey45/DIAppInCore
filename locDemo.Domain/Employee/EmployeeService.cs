using AutoMapper;
using locDemo.Repository.Employee;
using System.Collections.Generic;

namespace locDemo.Domain.Employee
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public Employee GetEmployee(int id)
        {
            EmployeeEntity employeeEntity = _employeeRepository.GetEmployee(id);
            var employee = _mapper.Map<EmployeeEntity, Employee>(employeeEntity);
            return employee;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            IEnumerable<EmployeeEntity> employeeEntities = _employeeRepository.GetEmployees();
            var employees = _mapper.Map<IEnumerable<EmployeeEntity>, IEnumerable<Employee>>(employeeEntities);
            return employees;
        }
    }
}
