using System;

namespace TestShop
{
    class TestShop
    {

        public static void Main()
        {

            Shop shop = null;

            Console.WriteLine("Instantiate the PizzaShop class:" + "\n");

            shop = new PizzaShop();

            string[] inventory = shop.getInventory();


            // list the inventory

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Argument" + i + " = " + inventory[i]);
            }


            // buy an item

            shop.buyInventory(inventory[1]);

        }

    }



    public abstract class Shop  {

        public void CalculateSaleTax() {

            Console.WriteLine("Calculate Sales Tax");

        }

        public abstract string[] getInventory();

        public abstract void buyInventory(string item);

    }

    public interface Nameable {

          string getName();
          void setName(string name);

    }

    public class PizzaShop : Shop , Nameable 
    {

        string _CompanyName;

        string[] foodOfferings = {
            "Pizza",
            "Spaghetti",
            "Garden Salad",
            "Anitpasto",
            "Calzone"
        };

        public override string[] getInventory() {

            return foodOfferings;

        }

        public override void buyInventory(string item) {

            Console.WriteLine("\nYou have just purchased " + item);

        }

        public string getName(){

            return _CompanyName;
        }

        public void setName(string name){

            _CompanyName = name;
        }

    }

    public class DonutShop : Shop , Nameable {

        string _CompanyName;

        string[] menuItems = {
            "Donuts",
            "Muffins",
            "Danish",
            "Coffee",
            "Tea"
        };

        public override string[]  getInventory() {

            return menuItems;

        }

        public override void  buyInventory(string item) {

            Console.WriteLine(string.format("\nYou have just purchased {0}.", item);

        }

        public string getName(){

            return _CompanyName;
        }

        public void setName(string name){

            _CompanyName = name;
        }
    }

}