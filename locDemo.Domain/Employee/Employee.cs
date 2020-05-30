namespace locDemo.Domain.Employee
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public EmployeeType Type { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
    }
}
