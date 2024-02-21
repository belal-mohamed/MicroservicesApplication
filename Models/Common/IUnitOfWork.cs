using PlatformService.Models.Interfaces.Repositories;

namespace PlatformService.Models.Common
{
    public interface IUnitOfWork 
    {
        IPlatformRepository PlatformRepository { get; }
        Task<int> CompleteAsync(CancellationToken cancellationToken);
    }
}