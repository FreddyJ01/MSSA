//Linear Search Demo
class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 10, 4, 7, 2, 1, 15, 12 };
        int target = 21;

        int index = LinearSearch(arr, target);

        if (index != -1)
        {
            System.Console.WriteLine($"Target was found at index: {index}");
        }
        else
        {
            System.Console.WriteLine("Target was not found!");
        }
    }

    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i;
            }
        }
        return -1;
    }
}