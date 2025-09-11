namespace MSSA.Projects;

class MiniRPGProject
{
    static void Main(string[] args)
    {
        // Variables
        Random attackPower = new Random();
        int heroHealth = 10;
        int monsterHealth = 10;
        int attack;
        string heroName;
        string monsterName;

        // User Input
        Console.Clear();
        System.Console.WriteLine("Enter Hero's Name: ");
        heroName = Console.ReadLine();
        Console.Clear();
        System.Console.WriteLine("Enter Monster's Name: ");
        monsterName = Console.ReadLine();
        Console.Clear();

        // Game function
        do
        {
            if (heroHealth > 0)
            {
                attack = attackPower.Next(1, 11);
                monsterHealth -= attack;
                System.Console.WriteLine($"{monsterName} was hit with {attack} power by {heroName} and has {(monsterHealth >= 0 ? monsterHealth : 0)} health remaining!");
            }
            else
            {
                System.Console.WriteLine($"{heroName} has been killed by {monsterName}!");
            }

            if (monsterHealth > 0)
            {
                attack = attackPower.Next(1, 11);
                heroHealth -= attack;
                System.Console.WriteLine($"{heroName} was hit with {attack} power by {monsterName} and has {(heroHealth >= 0 ? heroHealth : 0)} health remaining!");
            }
            else
            {
                System.Console.WriteLine($"{monsterName} has been killed by {heroName}!");
            }
        } while (monsterHealth > 0 && heroHealth > 0);
    }
}