using PlatformService.Models.Entities;

namespace PlatformService.Models.Interfaces.Repositories
{
    public interface IPlatformRepository
    {
        Task CreateAsync(Platform platform);
        Task<IEnumerable<Platform>> GetAllAsync();
        Task<Platform> GetAsync(int id);
    }
}
