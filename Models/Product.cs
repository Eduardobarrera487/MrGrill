using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrGrill.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public int category { get; set; }
        public bool isCombo { get; set; }
        public bool isActive { get; set; }
        
        public string photo { get; set; }
    }
}
