using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KantineClassLibrary
{
    public class Kantine
    {
        public string Foods { get; set; }
        public string Drinks { get; set; }
        public string Snacks { get; set; }
        public double Price { get; set; }

        public override string ToString()
        { //Override main Class Object.
            return Foods + Drinks + Snacks + " " + "€" + Price;
        }

        public Kantine(string a, string b, string c, double d)
        {
            Foods = a;
            Drinks = b;
            Snacks = c;
            Price = d;
        }

    }
}
