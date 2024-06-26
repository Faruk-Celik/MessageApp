using MessageApp.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageApp.DataAccessLayer.Context
{
    public class MessageAppContext : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-6VB768D\\SQLEXPRESS02; initial catalog=MessageAppDb; integrated Security=true;");
        }
        public DbSet<Message> Messages { get; set; }
    }
}
