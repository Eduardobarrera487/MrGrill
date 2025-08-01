using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrGrill.Models
{
    public class Sale
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public int userId { get; set; }
        public decimal total { get; set; }
        public string paymentMethod { get; set; }
        public string status { get; set; }  // e.g., "completed", "pending", "cancelled"
    }
}
