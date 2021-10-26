using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alkanzi.Services
{
    public interface IUserService
    {
        Task<IEnumerable<Users>> GetUsers();
        Task<Users> GetUserById(int Id);
        Task DeleteUser(int Id);
        Task<Users> AddUser(Users user);
        Task<Users> EditUser(Users user);
        Task<bool> Login(string name, string password);
    }
}
