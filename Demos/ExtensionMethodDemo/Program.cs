namespace MSSA.Demos;

public static class StringHelper
    {
        public static bool IsCapitalized(this string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            return char.IsUpper(s[0]);
        }
    }

class ExtensionMethodDemo
{
    static void Main(string[] Args)
    {
        string city1 = "Berlin";
        string city2 = "london";
        string city3 = "";

        Console.WriteLine($"{city1} is capitalized? {city1.IsCapitalized()}");
        Console.WriteLine($"{city2} is capitalized? {city2.IsCapitalized()}");
        Console.WriteLine($"Empty string is capitalized? {city3.IsCapitalized()}");

    }
}