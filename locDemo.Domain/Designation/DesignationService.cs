using AutoMapper;
using locDemo.Repository.Designation;
using System.Collections.Generic;

namespace locDemo.Domain.Designation
{
    public class DesignationService : IDesignationService
    {
        private readonly IMapper _mapper;
        private readonly IDesignationRepository _designationRepository;

        public DesignationService(IDesignationRepository designationRepository, IMapper mapper)
        {
            _designationRepository = designationRepository;
            _mapper = mapper;
        }

        public DesignationModel GetDesignation(string name)
        {
            DesignationEntity designationEntity = _designationRepository.GetDesignation(name);
            var designation = _mapper.Map<DesignationEntity, DesignationModel>(designationEntity);
            return designation;
        }

        public IEnumerable<DesignationModel> GetDesignations()
        {
            _designationRepository.GetDesignations();
            IEnumerable<DesignationEntity> designationEntities = _designationRepository.GetDesignations();
            var designations = _mapper.Map<IEnumerable<DesignationEntity>, IEnumerable<DesignationModel>>(designationEntities);
            return designations;
        }
    }
}
