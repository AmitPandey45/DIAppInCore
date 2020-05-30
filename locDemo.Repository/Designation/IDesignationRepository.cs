using System.Collections.Generic;

namespace locDemo.Repository.Designation
{
    public interface IDesignationRepository
    {
        DesignationEntity GetDesignation(string name);
        IEnumerable<DesignationEntity> GetDesignations();
    }
}
