using CemetaryManager.App.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CemetaryManager.App.Infrastructure.Data.Configuration
{
    public class LotPurchaseConfiguration : IEntityTypeConfiguration<LotPurchase>
    {
        public void Configure(EntityTypeBuilder<LotPurchase> builder)
        {
            builder.HasOne(x => x.Purchaser).WithMany().HasForeignKey(x => x.PurchaserId);
            builder.HasOne(x => x.LotPurchased).WithMany().HasForeignKey(x => x.LotId);
        }
    }
}
