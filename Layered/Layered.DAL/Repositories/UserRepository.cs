using Layered.DAL.Interfaces;
using Layered.DAL.Models;

namespace Layered.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IEnumerable<User> _users;

        public UserRepository()
        {
            _users = new List<User> {
                new User { Id = 1, Name = "Alice", Email = "alice@example.com" },
                new User { Id = 2, Name = "Bob", Email = "bob@example.com" }
            };
        }

        public IEnumerable<User> GetAllUsers() => _users;
    }
}