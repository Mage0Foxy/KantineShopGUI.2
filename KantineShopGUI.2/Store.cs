using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KantineClassLibrary
{
    public class Store
    {
        public List<Kantine> FoodList;
        public List<Kantine> ShoppingList;
       

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
