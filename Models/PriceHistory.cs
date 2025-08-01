using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrGrill.Models
{
    public class PriceHistory
    {
        public int id { get; set; }
        public int productId { get; set; }
        public decimal oldPrice { get; set; }
        public decimal newPrice { get; set; }
        public DateTime changeDate { get; set; }
        public int userId { get; set; }
    }
}
