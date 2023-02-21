using CemeteryManager.App.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CemeteryManager.App.Infrastructure.Data.Configuration
{
    public class GraveSiteConfiguration : IEntityTypeConfiguration<GraveSite>
    {
        public void Configure(EntityTypeBuilder<GraveSite> builder)
        {
            builder.Property(x => x.SiteNumber).HasMaxLength(15);
            builder.HasMany(x => x.Burials).WithOne().HasForeignKey(x => x.GraveSiteId);
        }
    }
}
