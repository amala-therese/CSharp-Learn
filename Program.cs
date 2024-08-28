
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
        }
    }
}
