using Microsoft.EntityFrameworkCore;
using PlatformService.Models.Entities;

namespace PlatformService.Infrastructure.Data.DatabaseContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> contextOptions) : base(contextOptions)
        {
                
        }

        public DbSet<Platform> Platforms { get; set; }
    }
}
