using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace WebApplication1.Data
{
    public class UserDbContext:DbContext
    {
        public DbSet<Models.User> Users { get; set; }
    }
}