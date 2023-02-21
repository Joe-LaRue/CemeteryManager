using System;

namespace CemetaryManager.App.Core.Entities
{
    public class Burial
    {
        public int Id { get; set; }
        public int GraveSiteId { get; set; }
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
}
