using App.BLL.DTOs;
using App.BLL.Interfaces;
using App.DAL.Interfaces;
using AutoMapper;

namespace App.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public IEnumerable<UserDto> GetUsers() => _mapper.Map<IEnumerable<UserDto>>(_userRepository.GetUsers());
    }
}