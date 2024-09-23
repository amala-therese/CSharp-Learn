
namespace CSharpConcepts;

    public interface IShape
    {
        double GetArea(); // Method to calculate the area
        double GetPerimeter(); // Method to calculate the perimeter
    }

    // Abstract class providing some default implementation
    public abstract class Shape
    {
        public abstract double GetArea(); // Abstract method to be implemented by derived classes
        public abstract double GetPerimeter(); // Abstract method to be implemented by derived classes

        // Concrete method with default behavior
        public void DisplayInfo()
        {
            Console.WriteLine("This is a shape.");
        }
    }

    // Class implementing the interface
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    // Class inheriting from abstract class and providing its own implementation
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Implementing abstract method
        public override double GetArea()
        {
            return Width * Height;
        }

        // Implementing abstract method
        public override double GetPerimeter()
        {
            return 2 * (Width + Height);
        }
    }