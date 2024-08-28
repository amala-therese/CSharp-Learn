
namespace CSharpConcepts
{
    public class BoxingAndUnboxing
    {
        public void Run()
        {
            // Boxing 
            int value = 123;
            object boxedValue = value;

            Console.WriteLine($"Value type: {value}");
            Console.WriteLine($"Boxed value: {boxedValue}");

            // Unboxing
            object boxedValueTwo = 456; 
            int unboxedValue = (int)boxedValueTwo;

            Console.WriteLine($"Second boxed value: {boxedValueTwo}");
            Console.WriteLine($"Unboxed value: {unboxedValue}");
           
        }
    }
}
