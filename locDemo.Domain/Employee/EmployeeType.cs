using System.ComponentModel;

namespace locDemo.Domain.Employee
{
    public enum EmployeeType
    {
        [Description("Permanent")]
        Permanent = 1,
        [Description("Consulted")]
        Consulted = 2,
        [Description("Shared")]
        Shared = 3
    }
}
