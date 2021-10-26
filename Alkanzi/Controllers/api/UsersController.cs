using Alkanzi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alkanzi.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService UserApi;
        public UsersController(IUserService UserApi)
        {
            this.UserApi = UserApi;
        }

        [HttpGet]
        public async Task<ActionResult> GetUsersApi()
        {
            return Ok(await UserApi.GetUsers());
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Users>> GetUserApi(int Id)
        {
            return await UserApi.GetUserById(Id);
        }
        [HttpPost]
        public async Task<ActionResult<Users>> AddUserApi(Users user)
        {
            return await UserApi.AddUser(user);
        }
        [HttpPut]
        public async Task<ActionResult<Users>> EditUserApi(Users user)
        {
            return await UserApi.EditUser(user);
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Users>> DeleteUserApi(int Id)
        {
            var tmp = await UserApi.GetUserById(Id);
            if (tmp != null)
            {
                await UserApi.DeleteUser(Id);
            }
            return tmp;
        }
        [HttpGet("{login}")]
        public async Task<ActionResult<bool>> Login(string name,string password)
        {
            return await UserApi.Login(name,password);
        }
    }
}
