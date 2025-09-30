//Hash Search Demo
class HashSearchExample
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 6, 3, 9, 6, 12, 7 };
        Dictionary<int, bool> dict = new Dictionary<int, bool>();

        foreach (int i in arr)
        {
            if (!dict.TryAdd(i, true))
            {
                System.Console.WriteLine($"Failed to add {i} as it is a duplicate.");
            }
            else
            {
                System.Console.WriteLine($"Succesfully added {i} to dictionary.");
            }
        }

        int existsInArr = 12;
        int notInArr = 4;

        LinearHashSearch(dict, existsInArr);
        LinearHashSearch(dict, notInArr);
    }

    static void LinearHashSearch(Dictionary<int, bool> dict, int searchValue)
    {
        if (dict.ContainsKey(searchValue))
        {
            System.Console.WriteLine($"{searchValue} was found in dictionary");
        }
        else
        {
            System.Console.WriteLine($"{searchValue} was not found in dictionary.");
        }
    }
}