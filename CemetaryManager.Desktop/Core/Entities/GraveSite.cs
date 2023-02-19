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
}
