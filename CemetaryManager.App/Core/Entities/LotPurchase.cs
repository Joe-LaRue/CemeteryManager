using System;

namespace CemetaryManager.App.Core.Entities
{
    public class LotPurchase
    {
        public int Id { get; set; }
        public int LotId { get; set; }
        public Lot LotPurchased { get; set; } = new Lot();
        public DateTime Purchased { get; set; }
        public int Price { get; set; }
        public int PerpetualCare { get; set; }
        public LotOwner Purchaser { get; set; } = new LotOwner();
        public int PurchaserId { get; set; }
    }
}
