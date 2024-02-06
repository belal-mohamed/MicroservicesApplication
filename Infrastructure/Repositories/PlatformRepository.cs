using Microsoft.EntityFrameworkCore;
using PlatformService.Infrastructure.Data.DatabaseContext;
using PlatformService.Models.Entities;
using PlatformService.Models.Interfaces.Repositories;

namespace PlatformService.Infrastructure.Repositories
{
    public class PlatformRepository : IPlatformRepository
    {
        private readonly AppDbContext _dbContext;

        public PlatformRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task CreateAsync(Platform platform) => await _dbContext.AddAsync(platform);

        public async Task<Platform> GetAsync(int id) => (await _dbContext.Platforms.FindAsync(id))!;

        public async Task<IEnumerable<Platform>> GetAllAsync() => await _dbContext.Platforms.ToListAsync();
    }
}
