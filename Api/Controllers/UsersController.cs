using Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersRepository repository;
        public UsersController(IUsersRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult> ApiGetUsers()
        {
            try
            {
                return Ok(await repository.GetUsers());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal Server Fetch users data error");
            }

        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Users>> ApiGetUserById(int Id)
        {
            try
            {
                var tmp = await repository.GetUserById(Id);
                if (tmp == null)
                {
                    return StatusCode(StatusCodes.Status404NotFound, $"No user with the Id ({Id})");
                }
                return tmp;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal Server Fetch user {Id} data error");
            }
        }
       
        [HttpPost]
        public async Task<ActionResult<Users>> ApiAddUser(Users user) {
            try
            {
                var tmp = await repository.AddUser(user);
                return tmp;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error to add new user");
            }
        }
        [HttpPut]
        public async Task<ActionResult<Users>> ApiEditUser(Users user)
        {
            try
            {
                var tmp = await repository.EditUser(user);
                if (tmp == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError,"failed to update user");
                }
                return tmp;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error to update  user");
            }
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Users>> ApiDeleteUser(int Id)
        {
            try
            {
                Users user = await repository.GetUserById(Id);
                if (user == null)
                {
                    return NotFound($"No user with the Id {Id}");
                }
                await repository.DeleteUser(user);
                return user;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error to Remove  user");
            }
        }

        [HttpGet("login")]
        public async Task<ActionResult<bool>> Login(string Name,string Password)
        {
            IEnumerable<Users> tmp  = await repository.Search(Name, Password);
            if (tmp.Count() > 0)
            {
                return true;
            }
            return false;
            //return Ok();
        }
    }
}
