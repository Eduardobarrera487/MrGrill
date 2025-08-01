using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrGrill.Models
{
    public class CashRegister
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public int idUser { get; set; }
        public DateTime OpeningTime { get; set; }
        public decimal initialAmount { get; set; }
        public DateTime? closingTime { get; set; } // This can be null if is not closed yet
        public decimal? finalAmount { get; set; }  // This can be null if is not closed yet
        public string observations { get; set; }
    }
}
