
using KantineClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KantineConsoleAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Store s = new Store();
            Console.WriteLine("Welcome to Canteen");
            int action = chooseAction();
            while (action != 0)
            {
                Console.WriteLine("You chose " + action);

                switch( action)
                {   //Add item to inventory
                    case 1:
                        Console.WriteLine("You choose to add a food to the inventory");

                        string Foods = "";
                        double Price = 0;

                        Console.WriteLine("What food do you choose? French Fries, Burger, Sandwich");
                        Foods = Console.ReadLine();

                        Console.WriteLine("What is the Price of the Food");
                        Price =  int.Parse(Console.ReadLine());

                        Kantine newFoods = new(Foods, Price);
                        s.FoodList.Add(newFoods);

                        printInventory(s);
                        break;

                    //Add to Cart
                    case 2:

                        Console.WriteLine("You choose to add a food to the shopping cart");
                        printInventory(s);
                        Console.WriteLine("Which item would you like to buy? (number)");
                        int FoodChosen = int.Parse(Console.ReadLine());

                        s.ShoppingList.Add(s.FoodList[FoodChosen]);
                        printShoppingCart(s);
                        break;

                    //Checkout
                    case 3:
                        printShoppingCart(s);
                        Console.WriteLine("The total cost of your items is : " + s.Checkout());

                        break;

                    default:
                        break;
                }


                action = chooseAction();
            }
        }

        private static void printShoppingCart(Store s)
        {
            Console.WriteLine("Items you have choosen to buy ");
            for (int i = 0; i < s.ShoppingList.Count; i++)
            {
                Console.WriteLine("Food #" + i + " " + s.ShoppingList[i]);
            }
        }

        private static void printInventory(Store s)
        {
            for (int i = 0; i < s.FoodList.Count; i++) 
            {
                Console.WriteLine("Food #" + i +" "+ s.FoodList[i]);
            }
        }

        static public int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("choose an action (0) to quit (1) to add food to inventory (2) add food to cart (3) checkout");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
