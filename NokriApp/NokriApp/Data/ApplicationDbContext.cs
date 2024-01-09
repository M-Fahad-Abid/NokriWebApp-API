using Microsoft.EntityFrameworkCore;
using NokriApp.Model;

namespace NokriApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Registration> Registrations { get; set; }
    }
}
