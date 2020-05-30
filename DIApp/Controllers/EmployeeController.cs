using AutoMapper;
using locDemo.Domain.Employee;
using locDemo.ViewModel.Employee;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace locDemo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }

        [HttpGet]
        //[Route("api/employee/GetEmployees")]
        public ActionResult<IEnumerable<EmployeeViewModel>> Get()
        {
            IEnumerable<Employee> employees = _employeeService.GetEmployees();
            IEnumerable<EmployeeViewModel> employeesData = _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(employees);
            return employeesData.ToList();
        }

        [HttpGet("{id}")]
        //[Route("api/employee/GetEmployee")]
        public ActionResult<EmployeeViewModel> Get(int id)
        {
            Employee employee = _employeeService.GetEmployee(id);
            EmployeeViewModel employeeData = _mapper.Map<Employee, EmployeeViewModel>(employee);
            return employeeData;
        }

        //[HttpGet]
        //[Route("api/employee/GetEmployeeName")]
        //public ActionResult<string> GetEmployeeName()
        //{
        //    return "Amit";
        //}
    }
}