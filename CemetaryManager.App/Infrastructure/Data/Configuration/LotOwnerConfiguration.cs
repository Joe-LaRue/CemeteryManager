using CemeteryManager.App.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CemeteryManager.App.Infrastructure.Data.Configuration
{
    public class LotOwnerConfiguration : IEntityTypeConfiguration<LotOwner>
    {
        public void Configure(EntityTypeBuilder<LotOwner> builder)
        {
            builder.Property(x => x.FirstName).HasMaxLength(50);
            builder.Property(x => x.LastName).HasMaxLength(50);
            builder.Property(x => x.Address).HasMaxLength(300);

        }
    }
}
