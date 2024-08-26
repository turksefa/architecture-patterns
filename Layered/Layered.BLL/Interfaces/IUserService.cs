using Layered.BLL.DTOs;

namespace Layered.BLL.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserDto> GetAllUsers();
    }
}