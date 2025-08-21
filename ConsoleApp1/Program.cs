using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace ConsoleApp1;

class Program
{
    // Creates the instance that generates a random number to randomize our give array in RandomizeAnimals method
    static Random groupRandomizer = new Random();
    // Creates the instance of our stack that we use to push and pop our randomized array of zoo animals
    static Stack<string>? randomizedStack = new Stack<string>();
    // The given array of animals currently at the petting zoo
    static readonly string[] pettingZoo =
    {
        "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", "ostriches", "pigs", "pones", "rabbits", "sheep", "tortoises"
    };

    static void Main(string[] Args)
    {
        // calls the UserInput Method and stores the return in the userInput variable
        string userInput = UserInput();
        // calls the schoolSelection Method passing in userInput variable and a call to RandomizeAnimals passing in pettingZoo array for randomization
        schoolSelection(userInput, RandomizeAnimals(pettingZoo));  
    }

    static string UserInput()
    {
        // Clear the console for visual appeal
        Console.Clear();
        // User Input String
        string userInput;
        // Boolean for user input test
        bool validInput;
        // User Prompt
        System.Console.WriteLine("What school do you attend? (School A, B, or C)");
        // Gathers user input, trims off spaces and makes input lowercase
        userInput = Console.ReadLine().ToLower().Trim(); // Hello
        // Sets condition for boolean to ensure user input is valid
        validInput = userInput == "school a" | userInput == "school b" | userInput == "school c" ? true : false;
        // Returns the users input when it passes validation
        if (validInput)
        {
            return userInput;
        }
        // Calls for user input again if the input is not valid
        return UserInput();
    }

    static Stack<string> RandomizeAnimals(string[] pettingZoo)
    {
        // Randomizes the array
        string[]? randomizedTemp = pettingZoo.OrderBy(x => groupRandomizer.Next()).ToArray();

        // Pushes the array into stack randomizedStack
        foreach (string temp in randomizedTemp)
        {
            // Stacks the animals from the randomized arry into a randomized stack
            randomizedStack.Push(temp);
        }

        // Returns the Randomized Stack
        return randomizedStack;
    }

    static void schoolSelection(string school, Stack<string> randomizedStack)
    {
        // Variable to store the number of groups based on school

        // Variable to store the group size based school and number of animals at zoo
        int groupSize;
        // Takes in which school the user input and returns the number of groups
        int groups = school switch
        {
            // if school a, sets groups to 6
            "school a" => groups = 6,
            // if school b, sets groups to 3
            "school b" => groups = 3,
            // if school c, sets groups to 2
            "school c" => groups = 2,
        };

        // Determines group size based on how many animals are at the zoo and how many groups are visiting
        groupSize = pettingZoo.Length / groups;
        // Calls the groupCreation method and gives it # of groups, group size, the random stack of animals and the school name
        groupCreation(groups, groupSize, randomizedStack, school);
    }

    static void groupCreation(int groups, int groupSize, Stack<string> randomizedStack, string school)
    {
        // Clear the console for application appearance
        Console.Clear();
        // Prints the School name to display "SCHOOL GROUPS"
        System.Console.WriteLine($"{school.ToUpper()} GROUPS");
        // Iterates through for as many groups as their are for the specific school
        for (int i = 0; i < groups; i++)
        {
            // Prints the group number in front of the animals in that group
            System.Console.Write($"Group {i + 1}: ");
            // Iterates through for as large as the group is
            for (int j = 0; j < groupSize; j++)
            {
                // Prints and removes the top animal in the stack
                Console.Write($"{randomizedStack.Pop()} ");
            }
            // Creates a newline after each group
            System.Console.WriteLine();
        }
    }
}