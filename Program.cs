
using SimpleDelegateExample;

namespace CSharpConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueType valueTypes = new ValueType();
            valueTypes.Run();

            ReferenceType referenceTypes = new ReferenceType();
            referenceTypes.Run();

            
            BoxingAndUnboxing boxingAndUnboxing = new BoxingAndUnboxing();
            boxingAndUnboxing.Run();

            SerializationAndDeserialization serializationExample = new SerializationAndDeserialization();
            serializationExample.Run();

            // Interface example: Circle implementing IShape
            Circle circle = new Circle(5);
            Console.WriteLine("Circle:");
            Console.WriteLine($"Area: {circle.GetArea()}");
            Console.WriteLine($"Perimeter: {circle.GetPerimeter()}");

            // Abstract class example: Rectangle inheriting from Shape
            Rectangle rectangle = new Rectangle(4, 7);
            Console.WriteLine("\nRectangle:");
            Console.WriteLine($"Area: {rectangle.GetArea()}");
            Console.WriteLine($"Perimeter: {rectangle.GetPerimeter()}");
            rectangle.DisplayInfo(); // Calling a concrete method from the abstract class

            DelegateSample del = new DelegateSample();
            del.Run();  // This will use the delegate to call Greet
        
        }
    }
}
