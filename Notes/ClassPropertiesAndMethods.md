
# Class Properties and Methods in C#

## Topics Covered
- Examining class members and the use of properties and methods
- Creating class properties and property accessors
- Creating classes that implement automatically implemented properties
- Restricting access to properties and property accessors using access modifiers
- Creating class methods and overloaded methods that accept reference and value type arguments
- Creating extension methods for a class
- **Exercise:** Update a class with properties and methods in C#

---

## Class Members

| Member      | Description |
|-------------|-------------|
| **Fields**        | Fields are variables declared at class scope. A field may be a built-in numeric type or an instance of another class. For example, a calendar class may have a field that contains the current date. |
| **Constants**     | Constants are fields whose value is set at compile time and can't be changed. |
| **Properties**    | Properties are methods on a class that are accessed as if they were fields on that class. A property can provide protection for a class field to keep it from being changed without the knowledge of the object. |
| **Methods**       | Methods define the actions that a class can perform. Methods can take parameters that provide input data, and can return output data through parameters. Methods can also return a value directly, without using a parameter. |
| **Events**        | Events provide notifications about occurrences, such as button clicks or the successful completion of a method, to other objects. Events are defined and triggered by using delegates. |
| **Operators**     | Overloaded operators are considered type members. When you overload an operator, you define it as a public static method in a type. |
| **Indexers**      | Indexers enable an object to be indexed in a manner similar to arrays. |
| **Constructors**  | Constructors are methods that are called when the object is first created. They're often used to initialize the data of an object. |
| **Finalizers**    | Finalizers are rarely used in C#. They're methods that are called by the runtime execution engine when the object is about to be removed from memory. They're used to make sure that any resources which must be released are handled appropriately. |
| **Nested Types**  | Nested types are types declared within another type. Nested types are often used to describe objects that are used only by the types that contain them. |

---

## Example: Class with Properties and Methods

```csharp
public class Person
{
    // Fields
    private string name;
    private int age;

    // Properties
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    // Constructors
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Methods
    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person("PersonName", 30);
        person.Display();
    }
}
```

---

## Getting Started with Class Properties and Accessors

Class properties provide a flexible mechanism to read, write, or compute the value of a data field. They appear as public data members, but they're implemented as special methods called accessors. This feature enables callers to access data easily and still helps promote data safety and flexibility.

### Example: Get Accessor
```csharp
public class Employee
{
    private string _name = "unknown";  // the name field
    public string Name
    {
        get { return _name; }  // the Name property
    }
}
```

### Example: Calculated Get Accessor
```csharp
public class Manager
{
    private string? _name;
    public string Name
    {
        get
        {
            return _name != null ? _name : "NA";
        }
    }
}
```

### Example: Set Accessor
```csharp
class Student
{
    private string? _name;  // the name field
    public string Name    // the Name property
    {
        get
        {
            return _name != null ? _name : "NA";
        }
        set
        {
            _name = value;
        }
    }
}
```

---

## The `init` Accessor

The code to create an init accessor is the same as the code to create a set accessor except that you use the `init` keyword instead of `set`. The difference is that the init accessor can only be used in the constructor or by using an object-initializer.

```csharp
class Person
{
    private string _name = "N/A";
    private int _age = 0;

    // Declare a Name property of type string:
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    // Declare an Age property of type int:
    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }
}

class TestPerson
{
    static void Main()
    {
        // Create a new Person object named person:
        Person person = new Person();

        // Print out the default name and age of the person:
        Console.WriteLine($"Person details - Name = {person.Name}, Age = {person.Age}");

        // Set some values on the person object:
        person.Name = "PersonName";
        person.Age = 99;
        Console.WriteLine($"Person details - Name = {person.Name}, Age = {person.Age}");

        // Increment the Age property:
        person.Age += 1;
        Console.WriteLine($"Person details - Name = {person.Name}, Age = {person.Age}");

        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
```

**Output:**
```
Person details - Name = N/A, Age = 0
Person details - Name = PersonName, Age = 99
Person details - Name = PersonName, Age = 100
```

---

## Expression Body Definitions for Accessors

You can use expression body definitions for concise get and set accessors:

```csharp
class Student
{
    private string? _name;  // the name field
    public string Name    // the Name property
    {
        get => _name ?? "NA";
        set => _name = value;
    }
}
```

```csharp
public class Person
{
    public string? FirstName 
    { 
        get;
        set => field = value.Trim(); 
    }
    // Omitted for brevity.
}
```

---

## Required Properties (C# 11+)

Beginning in C# 11, you can require callers to set a property:

```csharp
public class Person
{
    public Person() { }

    [SetsRequiredMembers]
    public Person(string firstName) => FirstName = firstName;

    public required string FirstName { get; init; }
    // Omitted for brevity.
}
```

---

## Restricting Access to Properties

A class can specify how accessible each of its members is to code outside of the class. Methods and variables that aren't intended to be used from outside of the class or assembly can be hidden to limit the potential for coding errors or malicious exploits.

Some methods and properties are meant to be called or accessed from code outside a class, known as client code. Other methods and properties might be only for use in the class itself. It's important to limit the accessibility of your code so that only the intended client code can reach it. You specify how accessible your types and their members are to client code by using the following access modifiers:

| Modifier            | Description |
|---------------------|-------------|
| `public`            | The type or member is accessible by any other code in the same assembly or another assembly that references it. |
| `protected`         | The type or member is only accessible by code in the same class or a derived class. |
| `internal`          | The type or member is accessible by any code in the same assembly, but not from another assembly. |
| `protected internal`| The type or member is accessible by any code in the same assembly, or by any derived class in another assembly. |
| `private`           | The type or member is only accessible by code in the same class or struct. |
| `private protected` | The type or member is only accessible by code in the same assembly, and only by code in the same class or a derived class. |

Class members are assigned private access by default.

| Member      | Description |
|-------------|-------------|
| **Fields**        | Fields are variables declared at class scope. A field may be a built-in numeric type or an instance of another class. For example, a calendar class may have a field that contains the current date. |
| **Constants**     | Constants are fields whose value is set at compile time and can't be changed. |
| **Properties**    | Properties are methods on a class that are accessed as if they were fields on that class. A property can provide protection for a class field to keep it from being changed without the knowledge of the object. |
| **Methods**       | Methods define the actions that a class can perform. Methods can take parameters that provide input data, and can return output data through parameters. Methods can also return a value directly, without using a parameter. |
| **Events**        | Events provide notifications about occurrences, such as button clicks or the successful completion of a method, to other objects. Events are defined and triggered by using delegates. |
| **Operators**     | Overloaded operators are considered type members. When you overload an operator, you define it as a public static method in a type. |
| **Indexers**      | Indexers enable an object to be indexed in a manner similar to arrays. |
| **Constructors**  | Constructors are methods that are called when the object is first created. They're often used to initialize the data of an object. |
| **Finalizers**    | Finalizers are rarely used in C#. They're methods that are called by the runtime execution engine when the object is about to be removed from memory. They're used to make sure that any resources which must be released are handled appropriately. |
| **Nested Types**  | Nested types are types declared within another type. Nested types are often used to describe objects that are used only by the types that contain them. |


```csharp
public class Person
{
    // Fields
    private string name;
    private int age;

    // Properties
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    // Constructors
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Methods
    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person("PersonName", 30);
        person.Display();
    }
}
```

Getting started with class properties and accesors

Class properties provide a flexible mechanism to read, write, or compute the value of a data field. They appear as public data members, but they're implemented as special methods called accessors. This feature enables callers to access data easily and still helps promote data safety and flexibility.

The following example shows a get accessor that returns the value of a private field _name:

public class Employee
{
    private string _name = "unknown";  // the name field
    public string Name
    {
        get { return _name; }  // the Name property
    }
}

The code block for a get accessor can also be used to return a calculated value. This can be useful when you want to ensure that a property always returns a non-null value. For example:
public class Manager
{
    private string? _name;
    public string Name
    {
        get
        {
            return _name != null ? _name : "NA";
        }
    }
}

In the following example, a set accessor is added to the Name property:
class Student
{
    private string? _name;  // the name field
    public string Name    // the Name property
    {
        get
        {
            return _name != null ? _name : "NA";
        }
        set
        {
            _name = value;
        }
    }
}

The init accessor
The code to create an init accessor is the same as the code to create a set accessor except that you use the init keyword instead of set. The difference is that the init accessor can only be used in the constructor or by using an object-initializer.

class Person
{
    private string _name = "N/A";
    private int _age = 0;

    // Declare a Name property of type string:
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    // Declare an Age property of type int:
    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            _age = value;
        }
    }
}

class TestPerson
{
    static void Main()
    {
        // Create a new Person object named person:
        Person person = new Person();

        // Print out the default name and age of the person:
        Console.WriteLine($"Person details - Name = {person.Name}, Age = {person.Age}");

        // Set some values on the person object:
        person.Name = "PersonName";
        person.Age = 99;
        Console.WriteLine($"Person details - Name = {person.Name}, Age = {person.Age}");

        // Increment the Age property:
        person.Age += 1;
        Console.WriteLine($"Person details - Name = {person.Name}, Age = {person.Age}");

        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}

/* Output:
Person details - Name = N/A, Age = 0
Person details - Name = PersonName, Age = 99
Person details - Name = PersonName, Age = 100
*/

The following code snippet updates the Student class using expression body definitions for the get and set accessors:

class Student
{
    private string? _name;  // the name field
    public string Name    // the Name property
    {
        get => _name ?? "NA";
        set => _name = value;
    }
}

public class Person
{
    public string? FirstName 
    { 
        get;
        set => field = value.Trim(); 
    }

    // Omitted for brevity.
}

Required properties
The preceding example allows a caller to create a Person using the default constructor, without setting the FirstName property. The property type is set to a nullable string. Beginning in C# 11, you can require callers to set a property:

public class Person
{
    public Person() { }

    [SetsRequiredMembers]
    public Person(string firstName) => FirstName = firstName;

    public required string FirstName { get; init; }

    // Omitted for brevity.
}


## Restricting Access to Properties

A class can control how accessible each of its members is to code outside of the class. This helps:
- Prevent coding errors
- Protect sensitive data
- Limit malicious exploits

Some members are meant to be accessed from outside the class (client code), while others are for internal use only. It's important to set the right accessibility so only intended code can reach your members.

### Access Modifiers in C#

| Modifier              | Description |
|-----------------------|-------------|
| `public`              | Accessible by any code in the same assembly or another assembly that references it. |
| `protected`           | Accessible only by code in the same class or a derived class. |
| `internal`            | Accessible by any code in the same assembly, but not from another assembly. |
| `protected internal`  | Accessible by any code in the same assembly, or by any derived class in another assembly. |
| `private`             | Accessible only by code in the same class or struct. |
| `private protected`   | Accessible only by code in the same assembly, and only by code in the same class or a derived class. |

> **Note:** Class members are assigned `private` access by default.

