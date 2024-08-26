using App.DAL.Models;

namespace App.DAL.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
    }
}