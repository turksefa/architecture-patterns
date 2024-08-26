using App.BLL.DTOs;
using App.DAL.Models;
using AutoMapper;

namespace App.BLL.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}