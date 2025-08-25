# TryCatchDemo

This folder demonstrates the use of **try-catch** blocks in C#. It provides examples and notes on how exception handling works in C#, including best practices, common patterns, and explanations.

---

## What is a Try-Catch Block?

A `try-catch` block is used to handle exceptions (unexpected errors) that may occur during the execution of a program. By catching exceptions, you prevent your program from crashing and can handle errors gracefully.

**Basic Structure:**
```csharp
try
{
    // Code that might throw an exception
}
catch (ExceptionType ex)
{
    // Code to handle the exception
}
```

- **try**: Encloses the code that may throw an exception.
- **catch**: Handles the exception if one is thrown. You can specify different exception types or use the base `Exception` class.

---

## Why Use Try-Catch Blocks?

- **Graceful error handling:** Prevents abrupt termination of the program.
- **Debugging:** Helps identify the source and type of error.
- **User experience:** Allows you to show friendly error messages.

---

## Example Usage

```csharp
try
{
    int result = 10 / int.Parse("0");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("You can't divide by zero!");
}
catch (FormatException ex)
{
    Console.WriteLine("Input was not a valid number.");
}
catch (Exception ex)
{
    Console.WriteLine("An unexpected error occurred: " + ex.Message);
}
```

### Multiple Catch Blocks

You can have multiple `catch` blocks for different exception types. The most specific exceptions should be caught before more general ones.

### The Finally Block

Optionally, you can include a `finally` block, which always runs, whether an exception was thrown or not (often used for cleanup code).

```csharp
try
{
    // Code
}
catch (Exception ex)
{
    // Handle error
}
finally
{
    // Cleanup code (e.g., closing files, releasing resources)
}
```

---

## Best Practices

- Catch only exceptions you can handle meaningfully.
- Avoid catching the base `Exception` unless you have a good reason.
- Log exceptions for diagnostics.
- Use the `finally` block for cleanup operations.
- Do not use exceptions for normal control flow.

---

## Common Exception Types

- `ArgumentNullException`
- `ArgumentOutOfRangeException`
- `InvalidOperationException`
- `NullReferenceException`
- `DivideByZeroException`
- `FormatException`
- `IOException`

---

## Example: Custom Exception Handling

You can create and throw your own exceptions:

```csharp
public class MyCustomException : Exception
{
    public MyCustomException(string message) : base(message) { }
}

try
{
    throw new MyCustomException("Something went wrong!");
}
catch (MyCustomException ex)
{
    Console.WriteLine(ex.Message);
}
```

---

## Summary

- Use `try-catch` to handle exceptions and keep your programs robust.
- Be specific with exception types.
- Always clean up resources using `finally` or with statements.
- Log and report errors as appropriate.

---

**Explore the code examples in this folder for hands-on demonstrations of these concepts.**
