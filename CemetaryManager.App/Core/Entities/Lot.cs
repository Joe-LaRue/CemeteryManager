using System.Collections.Generic;

namespace CemeteryManager.App.Core.Entities
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

        public DateTime Purchased { get; set; }
        public int? PurchasePrice { get; set; }
        public int? PerpetualCareCost { get; set; }
    }
}
