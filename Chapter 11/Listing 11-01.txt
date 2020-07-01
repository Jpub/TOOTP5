class Mammal {

    public void eat () {System.out.println("I am Eating");};
}
class Bat extends Mammal {
    public void fly () {System.out.println("I am Flying");}; 
}
class Dog extends Mammal {

    public void walk () {System.out.println("I am Walking");};
}
public class TestMammal {
    public static void main(String args[]) {

        System.out.println("Composition over Inheritance");;

        System.out.println("\nDog");
        Dog fido = new Dog();
        fido.eat();
        fido.walk();

        System.out.println("\nBat");
        Bat brown = new Bat();
        brown.eat();
        brown.fly();
    }
}
