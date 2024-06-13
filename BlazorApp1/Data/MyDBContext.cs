using BlazorApp1.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data 
{
    public class MyDBContext :  DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base (options) { }

        public DbSet<User> users { get; set; }

        public DbSet<Role> roles { get; set; }

        public DbSet<Post> posts { get; set; }

        public DbSet<UserSetting> userSettings { get; set; }
    }
}
