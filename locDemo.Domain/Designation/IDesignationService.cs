using System.Collections.Generic;

namespace locDemo.Domain.Designation
{
    public interface IDesignationService
    {
        DesignationModel GetDesignation(string name);
        IEnumerable<DesignationModel> GetDesignations();
    }
}
