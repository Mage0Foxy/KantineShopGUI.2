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

        public Kantine()
        {
            Foods = "Nothing yet";
            Drinks = "Nothing yet";
            Snacks = "Nothing yet";
            Price = 0.00;
        }

        public Kantine(string a, string b, string c, double d)
        {
            Foods = a;
            Drinks = b;
            Snacks = c;
            Price = d;
        }

        public Kantine(string? Foods, double Price)
        {
            Foods = Foods;
            Price = Price;
        }
    }
}
