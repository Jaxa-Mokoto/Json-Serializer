using System.Text.Json;
using Serializer.Models;

// create an instance of the person model
var person = new Person{
    Id = 1,
    Name = "John",
    LastName = "Wick",
    Age = 45,
    isAlive = true
};

// serialize the object
string jsonResult = JsonSerializer.Serialize(person);

// place serialized object into JSON file
var fileName = "person.json";
File.WriteAllText(fileName, jsonResult);