using AutoMapper;
using Layered.BLL.DTOs;
using Layered.DAL.Models;

namespace Layered.BLL.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}