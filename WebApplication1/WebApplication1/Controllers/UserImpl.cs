using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{

    public class UserImpl : IUserRepository
    {
        private readonly UserDbContext db;

        public UserImpl()
        {
            this.db = new UserDbContext();
        }
        public async Task<User> Create(User user)
        {
            db.Users.Add(user);
            await db.SaveChangesAsync();
            return user;
        }

        public async Task<User> Delete(int id)
        {
           var user= db.Users.Find(id);
            db.Users.Remove(user);
            await db.SaveChangesAsync();
                return user;
        }

      

       

        public async Task<User> GetById(int? id)
        {
            var user = await db.Users.FindAsync(id);
            return user;
        }

       

        public async Task<User> Update(int id, User user)
        {
            db.Entry(user).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return user;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            var user = await db.Users.ToListAsync();
            return user;
        }
    }
}