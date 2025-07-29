using System.Reflection;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        /* Project 1
        // Variables
        Console.Clear();
        int userInput;
        string? userString;
        bool isValid;

        // do-while to check the number
        do
        {
            System.Console.WriteLine("Enter A Number Between 5 & 10: ");
            userString = Console.ReadLine();
            isValid = int.TryParse(userString, out userInput);
        } while (!isValid || userInput < 5 || userInput > 10);

        Console.Clear();
        System.Console.WriteLine($"Your number is {userInput} and has been accepted!");
        */

        /* Project 2
        // Variables
        Console.Clear();
        string? roleName;
        bool nameValidation = true;

        // do-while to check if the role is acceptable
        do
        {
            System.Console.WriteLine("Enter Role: ");
            roleName = Console.ReadLine().Trim().ToLower();
            nameValidation = roleName == "administrator" ? false : roleName == "manager" ? false : roleName == "user" ? false : true;
        } while (nameValidation);

        Console.Clear();
        System.Console.WriteLine($"Access Granted, Welcome {roleName}!");
        */

        /*
        // Variables
        string[] myString = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

        foreach (string sentence in myString)
        {
            string remaining = sentence;
            int periodLocation;
            do
            {
                periodLocation = remaining.IndexOf(".");
                if (periodLocation > -1)
                {
                    Console.WriteLine("Sentence: " + remaining.Remove(periodLocation));
                    remaining = remaining.Substring(periodLocation + 1).TrimStart(' ');
                }
                else if (remaining.Length > 0)
                {
                    Console.WriteLine("Sentence: " + remaining.TrimStart());
                }

            } while (periodLocation > -1);
        }
        */
    }
}