class TestShop {

   public static void main (String args[]) {

      Shop shop = null;

      String className = "DonutShop";

      System.out.println("Instantiate the class:" + className + "\n");


      try {

	   // new pizzaShop();
       shop = (Shop)Class.forName(className).newInstance();

      } catch (Exception e) {

         e.printStackTrace();
      }

      String[] inventory = shop.getInventory();


      // list the inventory

      for (int i=0; i<inventory.length; i++) {
         System.out.println("Argument" + i + " = " + inventory[i]);
      }


      // buy an item

      shop.buyInventory(inventory[1]);

   }

}

public abstract class Shop  {

    CustList customerList;

    public void CalculateSaleTax() {

        System.out.println("Calculate Sales Tax");

    };

    public abstract String[] getInventory();

    public abstract void buyInventory(String item);

}

public interface Nameable {

    public abstract String getName();
    public abstract void setName(String name);

}

public class PizzaShop extends Shop implements Nameable {

    String companyName;


    String[] foodOfferings = {
        "Pizza",
        "Spaghetti",
        "Garden Salad",
        "Anitpasto",
        "Calzone"
    };

    public String[] getInventory() {

        return foodOfferings;

    }

    public void buyInventory(String item) {

        System.out.println("\nYou have just purchased " + item);

    }

    public String getName(){

        return companyName;
    }

    public void setName(String name){

        companyName = name;
    }

}

public class DonutShop extends Shop implements Nameable {

    String companyName;

    String[] menuItems = {
        "Donuts",
        "Muffins",
        "Danish",
        "Coffee",
        "Tea"
	};

    public String[] getInventory() {

        return menuItems;

    }

    public void buyInventory(String item) {

        System.out.println("\nYou have just purchased " + item);

    }

    public String getName(){

        return companyName;
    }

    public void setName(String name){

        companyName = name;
    }
}

public class CustList {

    String name;

    public  String findCust() {return name;}
    public  void addCust(String Name){}

}
