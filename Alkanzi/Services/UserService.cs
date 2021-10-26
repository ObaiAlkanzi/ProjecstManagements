using Microsoft.AspNetCore.Components;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Alkanzi.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient httpClient;
        public UserService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<Users> AddUser(Users user)
        {
            return await httpClient.PostJsonAsync<Users>("api/Users", user);
        }

        public async Task DeleteUser(int Id)
        {
             await httpClient.DeleteAsync($"api/Users/{Id}");
        }

        public async Task<Users> EditUser(Users user)
        {
            return await httpClient.PutJsonAsync<Users>("api/Users",user);
        }

        public async Task<Users> GetUserById(int Id)
        {
            return await httpClient.GetJsonAsync<Users>($"api/Users/{Id}");
        }

        public async Task<IEnumerable<Users>> GetUsers()
        {
            return await httpClient.GetJsonAsync<Users[]>("api/Users"); 
        }

        public async Task<bool> Login(string name, string password)
        {
            return await httpClient.GetJsonAsync<bool>($"api/Users/login?name={name}&password={password}");
        }
    }
}
