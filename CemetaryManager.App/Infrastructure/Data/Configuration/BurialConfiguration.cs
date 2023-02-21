using CemeteryManager.App.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CemeteryManager.App.Infrastructure.Data.Configuration
{
    public class BurialConfiguration : IEntityTypeConfiguration<Burial>
    {
        public void Configure(EntityTypeBuilder<Burial> builder)
        {
            builder.Property(x => x.FirstName).HasMaxLength(50);
            builder.Property(x => x.LastName).HasMaxLength(50);
            builder.Property(x => x.MilitaryBranch).HasMaxLength(50);
            builder.Property(x => x.Age).HasMaxLength(50);
                        
        }
    }
}
