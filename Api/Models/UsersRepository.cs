using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class UsersRepository : IUsersRepository
    {
        private readonly AppDbContext context;
        public UsersRepository(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<Users> AddUser(Users user)
        {
            var tmp = await context.DbUsers.AddAsync(user);
            await context.SaveChangesAsync();
            return tmp.Entity;
        }

        public async Task DeleteUser(Users user)
        {
             context.DbUsers.Remove(user);
             await   context.SaveChangesAsync();
        }

        public async Task<Users> EditUser(Users user)
        {
            Users tmp = await context.DbUsers.FirstOrDefaultAsync(c => c.Id == user.Id);
            tmp.Name = user.Name;
            tmp.Password = user.Password;
            tmp.Email = user.Email;
            tmp.accountState = user.accountState;
            await context.SaveChangesAsync();
            return tmp;
        }

        public async Task<Users> GetUserById(int Id)
        {
            return await context.DbUsers.FirstOrDefaultAsync(c => c.Id == Id);
        }

        public async Task<IEnumerable<Users>> GetUsers()
        {
            return await context.DbUsers.ToListAsync();
        }

        public async Task<IEnumerable<Users>> Search(string name, string password)
        {
            IQueryable<Users> query =  context.DbUsers;
            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(x=>x.Name == name);
            }
            if (!string.IsNullOrEmpty(password))
            {
                query = query.Where(x => x.Password == password);
            }
            return await query.ToListAsync();
        }
    }
}
