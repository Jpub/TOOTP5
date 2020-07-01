using System;

namespace TestShape
{
    public class TestShape
    {

        public static void Main()
        {

            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();

            circle.draw();
            rectangle.draw();

        }

    }

    public abstract class Shape
    {

        public abstract void draw();

    }

    public class Circle : Shape
    {

        public override void draw() 
        {

            Console.WriteLine("I am drawing a Circle");

        }
    }

    public class Rectangle : Shape
    {

        public override void draw()
        {

            Console.WriteLine("I am drawing a Rectangle");

        }
    }

    public class Star : Shape
    {

        public override void draw()
        {

            Console.WriteLine("I am drawing a Star");

        }
    }

    public class Triangle : Shape
    {

        public override void draw()
        {

            Console.WriteLine("I am drawing a Triangle");

        }
    }
}
