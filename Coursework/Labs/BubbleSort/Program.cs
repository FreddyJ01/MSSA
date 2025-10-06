using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 5, 2, 8, 3, 9 };
        System.Console.Write("Unsorted Array: ");
        Display(nums);
        BubbleSort(nums);
        System.Console.Write("Sorted Array: ");
        Display(nums);
    }

    static void Display(int[] nums)
    {
        string numsToString = String.Join(", ", nums);
        System.Console.WriteLine(numsToString);
    }

    static void BubbleSort(int[] nums)
    {
        bool swapped = false;
        do
        {
            swapped = false;
            for (int j = 0; j < nums.Length - 1; j++)
            {
                if (nums[j] > nums[j + 1])
                {
                    SwapHelper(ref nums[j], ref nums[j + 1]);
                    swapped = true;
                }
            }
        } while (swapped);
    }

    static void SwapHelper(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
}