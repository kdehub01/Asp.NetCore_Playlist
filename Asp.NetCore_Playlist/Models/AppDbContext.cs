using Microsoft.EntityFrameworkCore;

namespace Asp.NetCore_Playlist.Models
{
    public class AppDbContext : DbContext
    {
        // DbContextOptions<AppDbContext> to do any useful work needs to done by dbcontext class , so for that we need dbcontextoptions & it contains db providers info & connection string too
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
