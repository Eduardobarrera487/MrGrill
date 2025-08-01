using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrGrill.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public string role { get; set; } // "admin" or "user"
        public bool  state { get; set; } // "this could be active or innactive"
       
        public User()
        {
            // Default constructor
        }
        public User(String name, String user, String password, String role, bool state)
        {
            this.name = name;
            this.user = user;
            this.password = password;
            this.role = role;
            this.state = state;
        }


    }
}
