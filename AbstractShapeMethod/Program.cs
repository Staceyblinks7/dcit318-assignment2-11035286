using System;

namespace AbstractClassDemo
{
    // Abstract base class
    abstract class Shape
    {
        public abstract double GetArea(); // Abstract method
    }

    // Derived class: Circle
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Derived class: Rectangle
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a Circle object
            Shape circle = new Circle(5.0);
            Console.WriteLine($"Circle area: {circle.GetArea():F2}");

            // Create a Rectangle object
            Shape rectangle = new Rectangle(4.0, 6.0);
            Console.WriteLine($"Rectangle area: {rectangle.GetArea():F2}");

            Console.ReadLine(); // Keep console window open
        }
    }
}
