
namespace CSharpConcepts
{
    public class ValueType
    {
        public void Run()
        {
            int x = 10;
            int y = x;
            y = 20;

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
        }
    }
}
