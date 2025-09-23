Learn how to serialize and deserialize JavaScript Object Notation (JSON) strings using the JsonSerializer class, the JsonSerializerOptions class, and Data Transfer Objects.

Learning objectives
Explain the basics of JSON syntax and its use in data interchange and storage.

Use the System.Text.Json namespace in C# to work with JSON data.

Serialize C# objects into JSON strings using the JsonSerializer.Serialize method and customize the serialization process.

Deserialize JSON strings back into C# objects using the JsonSerializer.Deserialize method and customize the deserialization process.

Use the JsonSerializerOptions class and Data Transfer Objects (DTOs) to manage the serialization and deserialization of complex objects.

What is JSON?
JSON is a text-based format that represents structured data using key-value pairs. It's language-independent, meaning it can be used with any programming language. JSON is often used in web development for Application Programming Interfaces (APIs) to send and receive data between a client and a server.

{
  "name": "John Doe",
  "age": 30,
  "isEmployed": true,
  "address": {
    "street": "123 Main St",
    "city": "New York",
    "state": "NY"
  }
}

What is serialization?
Serialization is the process of converting the state of an object (the values of its properties) into a form that can be stored or transmitted. The serialized form doesn't include any information about an object's associated methods.

In the context of a C# application, serialization is used to convert a C# object into a JSON string. This is useful for saving data to files, sending data over networks, or storing data in databases. For example:

Serialization is essential for data interchange between different systems or applications, especially when they use different programming languages or platforms. It allows for easy sharing of data in a standardized format that can be understood by various systems.
Serialization is also used in web APIs to send and receive data between clients and servers. When a client makes a request to a server, the server can serialize the response data into JSON format, which the client can then deserialize back into an object.
Serialization is used in data storage scenarios, such as saving application state or user preferences. By serializing objects to JSON, developers can easily store and retrieve complex data structures without needing to manually parse or format the data.
Serialization is often used in caching mechanisms, where data is stored in a serialized format to improve performance and reduce the need for repeated database queries or computations.
Deserialization is the reverse process of serialization, where a JSON string is converted back into a C# object. Deserialization allows developers to work with JSON data in a more structured way, using C# objects and properties. This is particularly useful when working with APIs or external data sources that return JSON responses, or when working with information stored in JSON files.

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Employee
{
    public string Name { get; set; } = "Anette Thomsen";
    public int Age { get; set; }
    public string Address { get; set; } = "123 Main St";
}

class Program
{
    static void Main()
    {
        string jsonString1 = "{\"Name\":\"Anette Thomsen\",\"Age\":30,\"Address\":\"123 Main St\"}";
        string jsonString2 = @"{""Name"":""Anette Thomsen"",""Age"":30,""Address"":""123 Main St""}";
        var customer = JsonSerializer.Deserialize<Employee>(jsonString2);
        if (customer != null)
        {
            Console.WriteLine($"Name: {customer.Name}, Age: {customer.Age}, Address: {customer.Address}");
        }
        else
        {
            Console.WriteLine("Deserialization failed.");
        }
    }
}

// Output: Name: Anette Thomsen, Age: 30, Address: 123 Main St

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
}

class Program
{
    static void Main()
    {
        var customer = new Employee { Name = "Anette Thomsen", Age = 30, Address = "123 Main St" };
        string jsonString = JsonSerializer.Serialize(customer);
        Console.WriteLine(jsonString);
    }
}

// Output: {"Name":"Anette Thomsen","Age":30,"Address":"123 Main St"}