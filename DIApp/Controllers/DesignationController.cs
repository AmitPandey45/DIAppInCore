using AutoMapper;
using locDemo.Domain.Designation;
using locDemo.ViewModel.Designation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace locDemo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesignationController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IDesignationService _designationService;

        public DesignationController(IDesignationService designationService, IMapper mapper
            , IConfiguration configuration)
        {
            _designationService = designationService;
            _mapper = mapper;

            // First way  
            string value1 = configuration.GetSection("AllowedHosts").Value;
            // Second way  
            string value2 = configuration.GetValue<string>("Logging:LogLevel:Default");
        }

        [HttpGet]
        public ActionResult<IEnumerable<DesignationViewModel>> Get()
        {
            _designationService.GetDesignations();
            IEnumerable<DesignationModel> designations = _designationService.GetDesignations();
            IEnumerable<DesignationViewModel> designationsData = _mapper.Map<IEnumerable<DesignationModel>, IEnumerable<DesignationViewModel>>(designations);
            return designationsData.ToList();
        }

        [HttpGet("{name}")]
        public ActionResult<DesignationViewModel> Get(string name)
        {
            _designationService.GetDesignation(name);
            DesignationModel designation = _designationService.GetDesignation(name);
            DesignationViewModel designationData = _mapper.Map<DesignationModel, DesignationViewModel>(designation);
            return designationData;
        }
    }
}