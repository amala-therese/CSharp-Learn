
namespace CSharpConcepts
{
    public class ReferenceType
    {
        public void Run()
        {
            Person p1 = new Person { Name = "John" };
            Person p2 = p1;
            p2.Name = "Jane";

            Console.WriteLine($"p1.Name = {p1.Name}"); 
            Console.WriteLine($"p2.Name = {p2.Name}"); 
        }
    }

    public class Person
    {
        public string Name { get; set; }
    }
}
