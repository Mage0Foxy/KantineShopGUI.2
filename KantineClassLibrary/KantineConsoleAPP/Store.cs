using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KantineClassLibrary
{
    public class Store
    {
        public List<Kantine> FoodList { get; set; }
        public List<Kantine> ShoppingList { get; set; }
       

        public Store()
        {
            FoodList = new List<Kantine>();
            ShoppingList = new List<Kantine>();
        }

        public double Checkout()
        {
            //Initialize the cost
            double totalCost = 0;
            foreach (var f in ShoppingList)
            {
                totalCost = totalCost + f.Price;
            }
            ShoppingList.Clear();
            return totalCost;
        }
    }
}
