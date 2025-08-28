namespace AAA;

internal class Operations
{
    public static int Sum(int num1, int num2)
    {
        return (num1 + num2);
    }
}
class Program
{
    static void Main()
    {
        int a = 10;
        int b = 20;
        System.Console.WriteLine("Sum is " + Operations.Sum(a, b).ToString());
    }
}