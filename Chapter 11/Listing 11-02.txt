class Mammal {

    public void eat () {System.out.println("I am Eating");};

}
class Walkable {

    public void walk () {System.out.println("I am Walking");};

}
class Flyable {

    public void fly () {System.out.println("I am Flying");};

}
class Dog {

    Mammal dog = new Mammal();
    Walkable walker = new Walkable();

}
class Bat {

    Mammal bat = new Mammal();
    Flyable flyer = new Flyable();

}
public class TestMammal {
    public static void main(String args[]) {

        System.out.println("Composition over Inheritance");;

        System.out.println("\nDog");;
        Dog fido = new Dog();
        fido.dog.eat();
        fido.walker.walk();

        System.out.println("\nBat");;
        Bat brown = new Bat();
        brown.bat.eat();
        brown.flyer.fly();
    }
}
