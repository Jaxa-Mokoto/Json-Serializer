using System.Text.Json.Serialization;
namespace Serializer.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        [JsonPropertyName("surname")] // to name the serialised property as something else
        public string? LastName { get; set; }
        public int Age { get; set; }
        public bool isAlive { get; set; }
        public Address? Address { get; set; }
        public List<Phone>? Phones { get; set; }
    }
}