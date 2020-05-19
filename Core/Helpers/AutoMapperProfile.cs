using AutoMapper;
using WebApiSkeleton.Core.Domain;
using WebApiSkeleton.Core.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSkeleton.Core.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Register, User>();
            CreateMap<User, Information>();
            //CreateMap<Update, User>();
        }
    }
}
