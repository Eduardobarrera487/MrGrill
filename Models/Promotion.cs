using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrGrill.Models
{
    public class Promotion
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string type { get; set; } // Could be "percentage", "amount", etc.
        public decimal? discountPercentage { get; set; } // Nullable if not used
        public decimal? discountAmount { get; set; }     // Nullable if not used
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public bool isActive { get; set; }
    }
}
