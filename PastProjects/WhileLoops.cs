using System.Reflection;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Random Dice = new Random();
        int randomNum = Dice.Next(1, 21);

        do
        {
            randomNum = Dice.Next(1, 21);
            System.Console.WriteLine(randomNum);
        }
        while (randomNum != 13);

        while (randomNum != 13)
        {
            System.Console.WriteLine(randomNum);
            randomNum = Dice.Next(1, 21);
        }
    }
}