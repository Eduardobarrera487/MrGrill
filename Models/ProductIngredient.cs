using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrGrill.Models
{
    public class ProductIngredient
    {
        public int productId { get; set; }
        public int ingredientId { get; set; }
        public decimal quantity { get; set; } // Quantity of the ingredient used in the product
    }
}
