abstract class Shape {

    private ShapeType sType = null;

    public Shape(ShapeType sType) {
        this.sType = sType;
    }

    // Generate the shape
    protected abstract void generate();

}
class Circle extends Shape {

    Circle() {
        super(ShapeType.CIRCLE);
        generate();
    }

    @Override
    protected void generate() {
        System.out.println("Generating a Circle");
    }
}

class Square extends Shape {

    Square() {
        super(ShapeType.SQUARE);
        generate();
    }

    @Override
    protected void generate() {
        System.out.println("Generating a Square");
    }
}

class Triangle extends Shape {

    Triangle() {
        super(ShapeType.TRIANGLE);
        generate();
    }

    @Override
    protected void generate() {
        System.out.println("Generating a Triangle");
    }
}

class ShapeFactory {
    public static Shape generateShape(ShapeType sType) {
        Shape shape = null;
        switch (sType) {

        case CIRCLE:
            shape = new Circle();
            break; 

        case SQUARE:
            shape = new Square();
            break; 

        case TRIANGLE:
            shape = new Triangle();
            break;

        default:
            // throw an exception
            break;
        }
        return shape;
    }
}

public class TestFactoryPattern {
    public static void main(String[] args) {

        ShapeFactory.generateShape(ShapeType.CIRCLE);
        ShapeFactory.generateShape(ShapeType.SQUARE);
        ShapeFactory.generateShape(ShapeType.TRIANGLE);

    }
}

