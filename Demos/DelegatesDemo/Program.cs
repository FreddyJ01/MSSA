namespace MSSA.Demos;

public delegate int Calculator(int a, int b);
class DelegatesDemo
{
    // Methods matching the delegates signature
    static int Add(int x, int y) => x + y;
    static int Multiply(int x, int y) => x * y;
    static int Subtract(int x, int y) => x - y;

    static void Main(string[] Args)
    {
        System.Console.WriteLine("Enter operation (add, multiply, subtract): ");
        string input = Console.ReadLine();

        // Switch expression returns the delegate directly
        Calculator calc = input switch
        {
            "add" => Add,
            "Mulitply" => Multiply,
            "subtract" => Subtract,
            _ => throw new InvalidOperationException("Invalid operation.")
        };
        // Call the selected method through the delegate
        int result = calc(3, 4);
        System.Console.WriteLine("Result: " + result);
    }
}