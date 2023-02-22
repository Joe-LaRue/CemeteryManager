using CemeteryManager.App.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CemeteryManager.App.Infrastructure.Data.Configuration
{
    public class LotConfiguration : IEntityTypeConfiguration<Lot>
    {
        public void Configure(EntityTypeBuilder<Lot> builder)
        {
            builder.Property(x => x.LotNumber).HasMaxLength(25);
            builder.Property(x => x.LotOrientation).HasMaxLength(25);

            builder.HasOne(x => x.LotOwner).WithMany().HasForeignKey(x => x.LotOwnerId);
            builder.HasMany(x => x.GraveSites).WithOne().HasForeignKey(x => x.LotId);
        }
    }
}
