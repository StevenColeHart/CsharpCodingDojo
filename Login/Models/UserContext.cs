using Microsoft.EntityFrameworkCore;
 
namespace Login.Models
{
    public class UserContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        public DbSet<User> User { get; set; }
        // public DbSet<Activity> Activity {get; set;}
    }
}