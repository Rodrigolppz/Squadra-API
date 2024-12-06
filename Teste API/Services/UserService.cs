using System.Collections.Generic;
using System.Linq;
using Teste_API.Models;

namespace Teste_API.Services
{
    public class UserService
    {
        private readonly List<User> _users = new List<User>
        {
            new User { Id = 1, UserName = "Gerente", Password = "123456", Role = "Gerente" },
            new User { Id = 2, UserName = "Funcionario", Password = "654321", Role = "Funcionário" }
        };

        public List<User> GetAllUsers()
        {
            return _users;
        }

        public User GetUserById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }

        public void AddUser(User user)
        {
            user.Id = _users.Max(u => u.Id) + 1; // Gerar um novo ID único
            _users.Add(user);
        }

        public User Authenticate(string username, string password)
        {
            return _users.FirstOrDefault(user => user.UserName == username && user.Password == password);
        }
    }
}
