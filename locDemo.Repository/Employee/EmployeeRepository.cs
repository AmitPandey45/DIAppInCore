using System.Collections.Generic;
using System.Linq;

namespace locDemo.Repository.Employee
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public EmployeeEntity GetEmployee(int id)
        {
            return AllEmployees.Where(s => s.EmployeeId == id).FirstOrDefault();
        }

        public IEnumerable<EmployeeEntity> GetEmployees()
        {
            return AllEmployees;
        }

        private static IEnumerable<EmployeeEntity> AllEmployees => new List<EmployeeEntity>()
        {
            new EmployeeEntity()
            {
                EmployeeId =1,
                FirstName ="Amit",
                MiddleName ="Kumar",
                LastName ="Pandey",
                Type ="Permanent",
                Department ="Engineering",
                Email ="amit.p@icreon.com",
                Location ="Noida"
            },
            new EmployeeEntity()
            {
                EmployeeId =2,
                FirstName ="Ankit",
                MiddleName ="",
                LastName ="Singh",
                Type ="Permanent",
                Department ="Engineering",
                Email ="ankit.singh@icreon.com",
                Location ="Noida"
            },
            new EmployeeEntity()
            {
                EmployeeId =3,
                FirstName ="Ashwani",
                MiddleName ="",
                LastName ="Kumar",
                Type ="Permanent",
                Department ="Engineering",
                Email ="ashwani.kumar@icreon.com",
                Location ="Noida"
            },
            new EmployeeEntity()
            {
                EmployeeId =4,
                FirstName ="Danish",
                MiddleName ="",
                LastName ="Azazi",
                Type ="Permanent",
                Department ="Engineering",
                Email ="Danish.Azazi@icreon.com",
                Location ="Delhi"
            },
            new EmployeeEntity()
            {
                EmployeeId =5,
                FirstName ="Shadab",
                MiddleName ="",
                LastName ="Shakir",
                Type ="Consulted",
                Department ="Engineering",
                Email ="Shadab.Shakir@icreon.com",
                Location ="Delhi"
            },
            new EmployeeEntity()
            {
                EmployeeId =6,
                FirstName ="Dinesh",
                MiddleName ="",
                LastName ="Gupta",
                Type ="Shared",
                Department ="IT",
                Email ="Dinesh.Gupta@icreon.com",
                Location ="Greater Noida"
            },
        };
    }
}
