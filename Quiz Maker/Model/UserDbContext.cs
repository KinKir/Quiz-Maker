using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Maker.Model
{
    class UserDbContext : DbContext
    {
        public UserDbContext() : base("UserDbContext") { }        
        public DbSet<User> Users { get; set; } 
    }
}