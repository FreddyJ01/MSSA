namespace LINQDemo;

class Program
{
    static void Main(string[] Args)
    {
        string[] names = { "Tom", "Dick", "Harry" };
        IEnumerable<string> filteredNames = System.Linq.Enumerable.Where(names, n => n.Length >= 4);

        foreach (string n in filteredNames)
        {
            System.Console.WriteLine(n);
        }
    }
}