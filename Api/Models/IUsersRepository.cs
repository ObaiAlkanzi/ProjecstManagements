using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
namespace Api.Models
{
    public interface IUsersRepository
    {
        Task<IEnumerable<Users>> GetUsers();
        Task<Users> GetUserById(int Id);
        Task DeleteUser(Users user);
        Task<Users> AddUser(Users user);
        Task<Users> EditUser(Users user);
        Task<IEnumerable<Users>> Search(string name,string password);
    }
}
