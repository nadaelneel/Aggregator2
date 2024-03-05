using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Application.Feature.Query;
using UserApp.Data;

namespace User.Application.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile() 
        {
            CreateMap<Users, GetAllUserDots>().ReverseMap();
        }

    }
}
