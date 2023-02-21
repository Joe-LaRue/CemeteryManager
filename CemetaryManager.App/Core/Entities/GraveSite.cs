using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CemeteryManager.App.Core.Entities
{
    public class GraveSite
    {
        public int Id { get; set; }
        public int LotId { get; set; }
        public string SiteNumber { get; set; } = string.Empty;
        public List<Burial> Burials { get; set; } = new List<Burial>();
    }
}
