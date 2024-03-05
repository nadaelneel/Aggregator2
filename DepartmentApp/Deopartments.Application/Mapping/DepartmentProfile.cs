using AutoMapper;
using Deopartments.Application.Features.Query;
using Departments.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deopartments.Application.Mapping
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile() 
        {
            CreateMap<Department, DepertmentDto>().ReverseMap();
        }
    }
}
