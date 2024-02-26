using LeaveManagementWeb.Data;
using LeaveManagementWeb.Models;
using AutoMapper; 
using Microsoft.Build.Framework.Profiler;

namespace LeaveManagementWeb.Configurations
{
    public class MapperConfig : Profile  
    {
        public MapperConfig() {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
