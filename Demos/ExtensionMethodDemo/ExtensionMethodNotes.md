
# Extension Methods in C#

## What Are Extension Methods?
Extension methods allow you to "add" new methods to existing types without modifying their source code or creating a new derived type. They are especially useful for enhancing classes you do not own, such as .NET built-in types.

## How Do Extension Methods Work?
- An extension method is a static method inside a static class.
- The first parameter of the method specifies the type being extended, and is preceded by the `this` keyword.
- When called, extension methods appear as if they are instance methods on the extended type.

## Syntax Example

```csharp
public static class StringExtensions
{
	public static bool IsCapitalized(this string str)
	{
		if (string.IsNullOrEmpty(str)) return false;
		return char.IsUpper(str[0]);
	}
}
```

## Usage Example

```csharp
string city = "Seattle";
bool result = city.IsCapitalized(); // Calls the extension method
```

## Key Points
- Extension methods do not actually modify the original type.
- They are resolved at compile time, not runtime.
- You must include the namespace containing the extension method to use it.

## When to Use Extension Methods
- To add utility methods to types you cannot change.
- To keep code organized and readable.
- To implement fluent interfaces.

## Limitations
- Extension methods cannot access private members of the extended type.
- If an instance method with the same signature exists, it takes precedence over the extension method.
