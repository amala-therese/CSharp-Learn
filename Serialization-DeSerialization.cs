
using System.Text.Json; 

namespace CSharpConcepts
{
       public class SerializationAndDeserialization
    {
        public void Run()
        {

            Person person = new Person { Name = "Alice"};

            // SERIALIZATION: Converting the Person object to a JSON string
            string serializedPerson = JsonSerializer.Serialize(person);
            Console.WriteLine(serializedPerson);

            // Save serialized string to a file (optional)
            File.WriteAllText("person.json", serializedPerson);

            // DESERIALIZATION: Reading JSON from the string and converting it back to a Person object
            string jsonFromFile = File.ReadAllText("person.json");
            Person deserializedPerson = JsonSerializer.Deserialize<Person>(jsonFromFile);
            Console.WriteLine($"Name: {deserializedPerson.Name}");
        }
    }

}