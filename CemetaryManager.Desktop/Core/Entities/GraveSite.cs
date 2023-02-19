using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CemetaryManager.Desktop.Core.Entities
{
    public class GraveSite
    {
        public int Id { get; set; }
        public int SiteNumber { get; set; }
        public List<Burial> Burials { get; set; } = new List<Burial>();
    }

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

    public class LotPurchase
    {
        public int Id { get; set; }
        public DateTime Purchased { get; set; }
        public int Price { get; set; }
        public int PerpetualCare { get; set; }
        public LotOwner Purchaser { get; set; } = new LotOwner();
        public int PurchaserId { get; set; }
    }

    public class Burial
    {
        public int Id { get; set; }
        public int LotId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime? Born { get; set; }
        public DateTime? Died { get; set; }
        public DateTime? Buried { get; set; }
        public string Age { get; set; } = string.Empty;
        public string MilitaryBranch { get; set; } = string.Empty;
        public bool HasObituary { get; set; }
        public bool IsCremation { get; set; }
        public string Notes { get; set; } = string.Empty;
    }

    public class LotOwner
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

    }
}
