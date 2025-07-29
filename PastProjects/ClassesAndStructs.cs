using System.Reflection;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point();
        p1.x = 7;

        Point p2 = p1;
        System.Console.WriteLine($"p1.x is equal to {p1.x}");
        System.Console.WriteLine($"p2.x is equal to {p2.x}");
        p1.x = 9;
        System.Console.WriteLine($"p1.x is equal to {p1.x}");
        System.Console.WriteLine($"p2.x is equal to {p2.x}");
    }
}

// public struct Point
// {
//     public int x, y;
// }

    public class Point
    {
        public int x, y;
    }