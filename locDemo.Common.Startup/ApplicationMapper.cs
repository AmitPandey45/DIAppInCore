using AutoMapper;
using locDemo.Domain.Designation;
using locDemo.Domain.Employee;
using locDemo.Repository.Designation;
using locDemo.Repository.Employee;
using locDemo.ViewModel.Designation;
using locDemo.ViewModel.Employee;

namespace locDemo.Common.Startup
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            //CreateMap<EmployeeEntity, Employee>();
            //CreateMap<Employee, EmployeeEntity>();
            //CreateMap<Employee, EmployeeViewModel>();
            ////.ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.EmployeeId))
            ////.ForMember(dest => dest.Name, opt => opt.MapFrom(src => string.Join(" ", src.FirstName + src.MiddleName + src.LastName)))
            ////.ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
            ////.ForMember(dest => dest.Department, opt => opt.MapFrom(src => src.Department))
            ////.ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            ////.ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.Location));
            //CreateMap<EmployeeViewModel, Employee>();

            var config = new MapperConfiguration(cfg =>
            {
                CreateMap<EmployeeEntity, Employee>();
                CreateMap<Employee, EmployeeEntity>();
                CreateMap<Employee, EmployeeViewModel>();
                CreateMap<EmployeeViewModel, Employee>();

                CreateMap<DesignationEntity, DesignationModel>();
                CreateMap<DesignationModel, DesignationEntity>();
                CreateMap<DesignationModel, DesignationViewModel>();
                CreateMap<DesignationViewModel, DesignationModel>();
            });
        }
    }
}
