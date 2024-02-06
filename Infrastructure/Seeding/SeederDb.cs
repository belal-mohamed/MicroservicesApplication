using PlatformService.Infrastructure.Data.DatabaseContext;
using PlatformService.Models.Entities;

namespace PlatformService.Infrastructure.Seeding
{
    public static class SeederDb
    {
        public static void SeedData(IApplicationBuilder builder)
        {
            using(var scope = builder.ApplicationServices.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetService<AppDbContext>()!;

                //Seed Platforms
                SeedPlatforms(dbContext);

                dbContext.SaveChanges();
            }

        }

        private static void SeedPlatforms(AppDbContext? dbContext)
        {
            if (dbContext!.Platforms.Any())
                dbContext
                    .Platforms
                    .AddRange(new List<Platform>()
                    {
                        new("DotNet", "Microsoft", "Free"),
                        new("Sql Server Express", "Microsoft", "Free"),
                        new("Kubernets", "Cloud Native Computing Foundation", "Free")
                    });
        }
    }
}
