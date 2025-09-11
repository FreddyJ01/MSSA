namespace AAA;
 
class Program
{
    static void Main(string[] args)
    {
        ICollection<int> numbers = new List<int>();
        numbers.Add(10);
        numbers.Add(20);
        PrintSummary(numbers);
 
        numbers = new LinkedList<int>();
        numbers.Add(100);
        numbers.Add(200);
        PrintSummary(numbers);
 
        PrintSummary(new List<int> { 1, 2, 3 });
        PrintSummary(new LinkedList<int>(new [] { 1, 2, 3 }));
 
    }
 
    static void PrintSummary(ICollection<int> numbers)
    {
        Console.Write("Contents: ");
        foreach (var n in numbers)
            Console.Write(n + " ");
        Console.WriteLine();
        Console.WriteLine("Count: " + numbers.Count);
        Console.WriteLine();
    }
}