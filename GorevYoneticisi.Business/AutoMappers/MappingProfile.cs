using AutoMapper;
using GorevYoneticisi.Business.Dtos;
using GorevYoneticisi.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevYoneticisi.Business.AutoMappers
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<JobCreateDto, Job>();
            CreateMap<Job, JobCreateDto>();

            CreateMap<Job, JobDetailDto>().ForMember(dest=>dest.Duration,opt=>opt.MapFrom(src=>src.Duration.Name));
            

            
        }
    }
}
