using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrGrill.Models
{
    public class SaleDetail
    {
        public int id { get; set; }
        public int saleId { get; set; }
        public int productId { get; set; }
        public int quantity { get; set; }
        public decimal unitPrice { get; set; }
        public decimal appliedDiscount { get; set; }
        public decimal finalPrice { get; set; }
        public decimal subtotal { get; set; }
    }
}
