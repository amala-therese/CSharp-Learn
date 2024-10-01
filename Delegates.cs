

namespace SimpleDelegateExample
{
    // Declare a delegate that matches a method signature (a method that takes a string and returns void)
    public delegate void SimpleDelegate(string message);

    public class DelegateSample
    {
        // Create a method that matches the delegate's signature
        public void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        public void Run()
        {
            //  Create a delegate instance and assign it the method to call
            SimpleDelegate simpleDelegate = Greet;

            // Use the delegate to call the method
            simpleDelegate("Alice");
            simpleDelegate("Bob");
        }
    }
}
