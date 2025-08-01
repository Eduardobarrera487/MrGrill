using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrGrill.Models
{
    public class Ingredient
    {
        public int id { get; set; }
        public string name { get; set; }
        public string unit { get; set; }          // e.g., grams, liters, pieces
        public decimal currentStock { get; set; }
        public decimal minimumStock { get; set; }
    }
}
