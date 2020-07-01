
public class TestShape {
    
    public static void main(String[] args) {
    	
    	System.out.println("Hello World!");
    	
    	Circle circle = new Circle();
    	Rectangle rectangle = new Rectangle();
    	
    	circle.draw();
    	rectangle.draw();
    	
    }
}

public abstract class Shape{

    public abstract void draw();

}

public class Rectangle extends Shape{

    public void draw() {

        System.out.println("I am drawing a Rectangle");

    }
}

public class Circle extends Shape{

    public void draw() {

        System.out.println("I am drawing a Circle");

    }
}

public class Star extends Shape{

    public void draw() {

        System.out.println("I am drawing a Star");

    }
}


public class Triangle extends Shape{

    public void draw() {

        System.out.println("I am drawing a Triangle");

    }
}
