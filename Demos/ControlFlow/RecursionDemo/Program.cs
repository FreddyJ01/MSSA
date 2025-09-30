namespace MSSA.Demos;

class RecursionDemo
{
    static int counter = 0;
    static void Main(string[] args)
    {
        Recurse();
    }

    static void Recurse()
    {
        int x = counter++;
        System.Console.WriteLine(
            @$"Recursion depth: {x} Recursion depth: {x} Recursion depth: {x} Recursion depth: {x} Recursion depth: {x} Recursion depth: {x} Recursion depth: {x} Recursion depth: {x} Recursion depth: {x} Recursion depth: {x} Recursion depth: {x} Recursion depth: {x}"
            );
        Thread.Sleep(1);
        Recurse();
    }
}