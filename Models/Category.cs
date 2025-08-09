using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrGrill.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Estado { get; set; }  // nueva propiedad

        public Category(int id, string name, string description, string estado)
        {
            Id = id;
            Name = name;
            Estado = estado;    
            
        }

        public Category() { }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
