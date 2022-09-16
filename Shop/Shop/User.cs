using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class User
    {
        public User()
        {
            Cart = new Cart();
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public Cart Cart { get; init; }
    }
}
