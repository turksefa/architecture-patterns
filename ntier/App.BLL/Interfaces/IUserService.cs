using App.BLL.DTOs;
using App.DAL.Models;

namespace App.BLL.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserDto> GetUsers();
    }
}