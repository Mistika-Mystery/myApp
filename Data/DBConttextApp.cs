using Microsoft.EntityFrameworkCore;
using myApp.Models;

namespace myApp.Data
{
    public class DBConttextApp: DbContext
    {
        DBConttextApp(DbContextOptions<DBConttextApp> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

    }
}
