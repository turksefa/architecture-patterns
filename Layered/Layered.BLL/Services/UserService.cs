using AutoMapper;
using Layered.BLL.DTOs;
using Layered.BLL.Interfaces;
using Layered.DAL.Interfaces;

namespace Layered.BLL.Services
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

        public IEnumerable<UserDto> GetAllUsers() => _mapper.Map<IEnumerable<UserDto>>(_userRepository.GetAllUsers());
    }
}