using System.Reflection;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Box Height: ");
        string height = Console.ReadLine();
        System.Console.WriteLine("Enter Box Length: ");
        string length = Console.ReadLine();

        System.Console.WriteLine("Your Box:");
        System.Console.WriteLine();
        boxMaker(int.Parse(height), int.Parse(length));
        
        void boxMaker(int height, int length)
        {
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= length; j++)
                {
                    if (j == length && j % 2 != 0)
                    {
                        System.Console.WriteLine("X");
                    }
                    else if (j == length)
                    {
                        System.Console.WriteLine("O");
                    }
                    else if (j % 2 != 0)
                    {
                        Console.Write("X");
                    }
                    else if (j % 2 == 0)
                    {
                        Console.Write("O");
                    }
                }
            }
        }
    }
}