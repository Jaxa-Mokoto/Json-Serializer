using System.Text.Json;
using Serializer.Models;
using Serializer.Helpers;

// create an instance of the person model
var person = new Person{
    Id = 1,
    Name = "John",
    LastName = "Wick",
    Age = 45,
    isAlive = true,
    Address = new Address // demonstrate nesting in objects
    {
        StreetName = "1 York Street",
        City = "Sydeny",
        ZipCode = 2000
    },
    Phones = new List<Phone>()
    {
        new Phone { PhoneType = "Home", PhoneNumber = 0231522565},
        new Phone { PhoneType = "Mobile", PhoneNumber = 0451522565},
        new Phone { PhoneType = "Home", PhoneNumber = 0231526755}
    },
    EyeColor = "blue" // will not appear because this is a fieldm not a property unless [JsonInclude] is set on model
};

// set the options for the json object
var options = new JsonSerializerOptions{
    WriteIndented = true,
    PropertyNamingPolicy =  new LowerCaseNamingPolicy(),
    IncludeFields = true // makes all fields exposed - not best practice.
};

// serialize the object
string jsonResult = JsonSerializer.Serialize<Person>(person, options);

// place serialized object into JSON file
var fileName = "person.json";
File.WriteAllText(fileName, jsonResult);