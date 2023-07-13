using AutoMapper;
using LeaveManagement.web.Data;
using LeaveManagement.web.Models;

namespace LeaveManagement.web.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig() //Constructor
        { 
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
