using Back.Models;
using Microsoft.EntityFrameworkCore;

namespace Back.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options) { }

        public DbSet<UserViewModel> Users { get; set; }
    }
}
