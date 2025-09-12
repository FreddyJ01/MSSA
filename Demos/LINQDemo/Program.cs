namespace MSSA.Demos;

class LINQDemo
{
    static void Main(string[] Args)
    {
        string[] names = { "Tom", "Dick", "Harry" };
        IEnumerable<string> filtered = names.Where(n => n.Contains("a"));
        IEnumerable<string> sorted = filtered.OrderBy(n => n.Length);
        IEnumerable<string> projected = sorted.Select(n => n.ToUpper());

        IEnumerable<string> filteredNames = System.Linq.Enumerable.Where(names, n => n.Length >= 4);

        foreach (string n in filteredNames)
        {
            System.Console.WriteLine(n);
        }

        foreach (string name in filtered)
        {
            System.Console.WriteLine(name + "|");
        }
        System.Console.WriteLine();

        foreach (string name in sorted)
        {
            System.Console.WriteLine(name + "|");
        }
        System.Console.WriteLine();

        foreach (string name in projected)
        {
            System.Console.WriteLine(name + "|");
        }

        int[] numbers = { 10, 9, 8, 7, 6 };
        IEnumerable<int> col1 = numbers.Take(3); // {10, 9, 8}
        IEnumerable<int> col2 = numbers.Skip(3); // {7, 6}
        IEnumerable<int> col3 = numbers.Reverse(); // {6, 7, 8, 9, 10}

        int firstNumber = numbers.First(); // 10
        int lastNumber = numbers.Last(); // 6
        int secondNumber = numbers.ElementAt(1); // 9
        int someNumber = numbers.OrderBy(n => n).Skip(1).First(); // 7

        // Aggregation Operators
        int count = numbers.Count(); // 5
        int min = numbers.Min(); // 6
        int max = numbers.Max(); // 10

        // Boolean Operators
        bool hasAnOddElement = numbers.Any(n => n % 2 != 0); // True

        // Concat and Union Operator
        int[] seq1 = { 1, 2, 3 };
        int[] seq2 = { 3, 4, 5 };

        IEnumerable<int> concat = seq1.Concat(seq2); // {1, 2, 3, 3, 4, 5, 6}
        IEnumerable<int> union = seq1.Union(seq2); // {1, 2, 3, 4, 5, 6}
    }
}