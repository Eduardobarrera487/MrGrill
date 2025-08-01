using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrGrill.Models
{
    public class InventoryMovement
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public int ingredientId { get; set; }
        public string movementType { get; set; }     // e.g., "entry", "exit"
        public decimal quantity { get; set; }
        public string observations { get; set; }
        public string reference { get; set; }        // e.g., invoice number or document
    }
}
