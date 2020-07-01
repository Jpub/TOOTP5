public class TestShape {
	
	public static void main(String args[]) {

		Circle circle = new Circle(5);
		System.out.println(circle.calcArea());
		
		Rectangle rectangle = new Rectangle(4,5);
		System.out.println(rectangle.calcArea());
		
	}
		
}
abstract class Shape{

    protected double area;

    public abstract double calcArea();

}
class Circle extends Shape{

    private double radius;

    public Circle(double r) {

        radius = r;

    }

    public double calcArea() {

        area = 3.14*(radius*radius);
        return (area);

    };
}
class Rectangle extends Shape{

    private double length;
    private double width;

    public Rectangle(double l, double w){
        length = l;
        width = w;
    }

    public double calcArea() {
        area = length*width;
        return (area);
    };
}