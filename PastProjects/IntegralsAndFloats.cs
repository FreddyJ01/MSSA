using System.Reflection;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        // Integral Types
        // MinValue and MaxValue Properties
        // Signed and Unsigned Integrals

        System.Console.WriteLine($"sbyte Min = {sbyte.MinValue}, sbyte Max = {sbyte.MaxValue}");
        System.Console.WriteLine($"short Min = {short.MinValue}, short Max = {short.MaxValue}");
        System.Console.WriteLine($"int Min = {int.MinValue}, int Max = {int.MaxValue}");
        System.Console.WriteLine($"long Min = {long.MinValue}, long Max = {long.MaxValue}");

        // Floating-Point Types
        // Consider: Precision, Manner (Base 2 [float, double] or Base 10 [decimal]) Decimal is more precise that float or double.

        decimal x = 0.1m;
        System.Console.WriteLine($"Decimal: {x + x + x + x + x + x + x + x + x + x}");

        float y = 0.1f;
        System.Console.WriteLine($"Float: {y + y + y + y + y + y + y + y + y + y}");
                                
    }
}