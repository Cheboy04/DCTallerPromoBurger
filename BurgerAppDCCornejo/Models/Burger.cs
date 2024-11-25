using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerAppDCCornejo.Models
{
    public class Burger
    {
        public int burgerID { get; set; }
        public string name { get; set; }
        public bool withCheese { get; set; }
        public decimal price { get; set; }
        // public List<object> promos { get; set; }
    }
}
