namespace ConsoleApp1;
 
using System;
using System.ComponentModel.Design;
 
class Program
{
    static void Main()
    {
        // the ourAnimals array will store the following:
        string animalSpecies = "";
        string animalID = "";
        string animalAge = "";
        string animalPhysicalDescription = "";
        string animalPersonalityDescription = "";
        string animalNickname = "";
 
        // variables that support data entry
        int maxPets = 8;
        string? readResult;
        string menuSelection = "";
 
        // array used to store runtime data, there is no persisted data
        string[,] ourAnimals = new string[maxPets, 6];
 
        // create some initial ourAnimals array entries
        for (int i = 0; i < maxPets; i++)
        {
            switch (i)
            {
                case 0:
                    animalSpecies = "dog";
                    animalID = "d1";
                    animalAge = "2";
                    animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
                    animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                    animalNickname = "lola";
                    break;
 
                case 1:
                    animalSpecies = "dog";
                    animalID = "d2";
                    animalAge = "9";
                    animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                    animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                    animalNickname = "loki";
                    break;
 
                case 2:
                    animalSpecies = "cat";
                    animalID = "c3";
                    animalAge = "1";
                    animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                    animalPersonalityDescription = "friendly";
                    animalNickname = "Puss";
                    break;
 
                case 3:
                    animalSpecies = "cat";
                    animalID = "c4";
                    animalAge = "?";
                    animalPhysicalDescription = "";
                    animalPersonalityDescription = "";
                    animalNickname = "";
                    break;
 
                default:
                    animalSpecies = "";
                    animalID = "";
                    animalAge = "";
                    animalPhysicalDescription = "";
                    animalPersonalityDescription = "";
                    animalNickname = "";
                    break;
            }
            ourAnimals[i, 0] = "ID #: " + animalID;
            ourAnimals[i, 1] = "Species: " + animalSpecies;
            ourAnimals[i, 2] = "Age: " + animalAge;
            ourAnimals[i, 3] = "Nickname: " + animalNickname;
            ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
            ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
        }
 
        // display the top-level menu options
 
        do
        {
            Console.Clear();
 
            Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
            Console.WriteLine(" 1. List all of our current pet information");
            Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
            Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
            Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
            Console.WriteLine(" 5. Edit an animal’s age");
            Console.WriteLine(" 6. Edit an animal’s personality description");
            Console.WriteLine(" 7. Display all cats with a specified characteristic");
            Console.WriteLine(" 8. Display all dogs with a specified characteristic");
            Console.WriteLine();
            Console.WriteLine("Enter your selection number (or type Exit to exit the program)");
 
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                menuSelection = readResult.ToLower();
            }
 
            switch (menuSelection)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Current pet listings:\n");
 
                    for (int i = 0; i < maxPets; i++)
                    {
                        if (!string.IsNullOrWhiteSpace(ourAnimals[i, 0]) && ourAnimals[i, 0] != "ID #: ")
                        {
                            Console.WriteLine($"Record {i + 1}: ");
                            for (int j = 0; j < 6; j++)
                            {
                                Console.WriteLine(ourAnimals[i, j]);
                            }
                            Console.WriteLine();
                        }
                    }
                    // pause code execution
                        Console.ReadLine();
                    break;
 
                case "2":
                    Console.Clear();
                    int petCount = 0;
                    for (int i = 0; i < maxPets; i++)
                    {
                        if (!string.IsNullOrWhiteSpace(ourAnimals[i, 0]) && ourAnimals[i, 0] != "ID #: ")
                        {
                            petCount++;
                        }
 
                        if (petCount >=  maxPets)
                        {
                            Console.WriteLine("Our shelter is full. No space to add more pets");
                            Console.WriteLine("Press the Enter key to continue");
                            // pause code execution
                            Console.ReadLine();
                            break;
                        }
                    }
                    int newIndex = petCount;
 
                    Console.WriteLine("Enter animal species (dog or cat):");
                    string? speciesInput = Console.ReadLine()?.Trim().ToLower();
                    while (speciesInput != "dog" && speciesInput != "cat")
                    {
                        Console.WriteLine("Enter either dog or cat:");
                        speciesInput = Console.ReadLine()?.Trim().ToLower();
                    }
 
                    string newID = (speciesInput == "cat" ? "c" : "d") + (newIndex + 1).ToString();
 
                    Console.WriteLine("Enter animal age:");
                    string? ageInput = Console.ReadLine()?.Trim();
                    while (!int.TryParse(ageInput, out _))
                    {
                        Console.WriteLine("Enter a valid numeric age:");
                        ageInput = Console.ReadLine()?.Trim();
                    }
 
                    Console.WriteLine("Enter animal physical description:");
                    string? descInput = Console.ReadLine()?.Trim();
                    while (string.IsNullOrWhiteSpace(descInput))
                    {
                        Console.WriteLine("Enter non-empty physical description:");
                        descInput = Console.ReadLine()?.Trim();
                    }
 
                    Console.WriteLine("Enter animal personality description:");
                    string? personalityInput = Console.ReadLine()?.Trim();
                    while (string.IsNullOrWhiteSpace(personalityInput))
                    {
                        Console.WriteLine("Enter non-empty personality description:");
                        personalityInput = Console.ReadLine()?.Trim();
                    }
 
                    Console.WriteLine("Enter animal nickname:");
                    string? nicknameInput = Console.ReadLine()?.Trim();
                    while (string.IsNullOrWhiteSpace(nicknameInput))
                    {
                        Console.WriteLine("Enter non-empty nickname:");
                        nicknameInput = Console.ReadLine()?.Trim();
                    }
 
                    ourAnimals[newIndex, 0] = $"ID #: {newID}";
                    ourAnimals[newIndex, 1] = $"Species: {speciesInput}";
                    ourAnimals[newIndex, 2] = $"Age: {ageInput}";
                    ourAnimals[newIndex, 3] = $"Nickname: {nicknameInput}";
                    ourAnimals[newIndex, 4] = $"Physical description: {descInput}";
                    ourAnimals[newIndex, 5] = $"Personality: {personalityInput}";
 
                    Console.WriteLine("\n New pet added successfully");
                    Console.WriteLine("Press the Enter key to continue");
                    // pause code execution
                    Console.ReadLine();
                    break;
 
                case "exit":
                    Console.WriteLine("Exiting application...");
                    break;
 
                default:
                    Console.WriteLine($"You selected menu option {menuSelection}.");
                    Console.WriteLine("This option is not implemented yet");
                    Console.WriteLine("Press the Enter key to continue");
                    // pause code execution
                    Console.ReadLine();
                    break;
            }
 
        } while (menuSelection != "exit");
    }
}