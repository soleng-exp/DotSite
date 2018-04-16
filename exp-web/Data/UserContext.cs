using exp_web.Models;
using Microsoft.EntityFrameworkCore;

namespace exp_web.Data
{
    public class UserContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public UserContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=db.sqlite");
        }

        public DbSet<User> Users { get; set; }
    }
}