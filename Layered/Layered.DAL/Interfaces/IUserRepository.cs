using Layered.DAL.Models;

namespace Layered.DAL.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
    }
}