using System.Collections.Generic;

namespace CemetaryManager.Desktop.Core.Entities
{
    public class Lot
    {
        public int Id { get; set; }
        public string LotId { get; set; } = string.Empty;
        public LotOwner? LotOwner { get; set; }
        public int? LotOwnerId { get; set; }
        public List<GraveSite> GraveSites { get; set; } = new List<GraveSite>();
        public string Notes { get; set; } = string.Empty;
        public int LotSize { get; set; }
        public string LotOrientation { get; set; } = string.Empty;
        public List<LotPurchase> LotPurchases { get; set; } = new List<LotPurchase>();
    }
}
