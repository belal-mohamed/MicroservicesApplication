using PlatformService.Infrastructure.Data.DatabaseContext;
using PlatformService.Models.Common;
using PlatformService.Models.Interfaces.Repositories;

namespace PlatformService.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IPlatformRepository PlatformRepository { get; }

        public UnitOfWork(
            AppDbContext context,
            IPlatformRepository platformRepository)
        {
            _context = context;
            PlatformRepository = platformRepository;
        }
        public async Task<int> CompleteAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}