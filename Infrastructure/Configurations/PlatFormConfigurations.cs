using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlatformService.Models.Entities;

namespace PlatformService.Infrastructure.Configurations
{
    public class PlatFormConfigurations : IEntityTypeConfiguration<Platform>
    {
        public void Configure(EntityTypeBuilder<Platform> builder)
        {
            builder
                .Property(p => p.Name)
                .IsRequired();

            builder
                .Property(p => p.Publisher)
                .IsRequired();

            builder
                .Property(p => p.Cost)
                .IsRequired();

        }
    }
}
