class Program
{
    static void Main()
    {
        int[] nums = { 7, 4, 10, 5, 1, 8 };
        System.Console.Write("Unsorted Array: ");
        Display(nums);

        System.Console.Write("Sorted Array: ");
        MergeSort(nums);
        Display(nums);
    }

    static void Display(int[] nums)
    {
        System.Console.WriteLine(string.Join(", ", nums));
    }

    static void MergeSort(int[] nums)
    {
        Array.Sort(nums);
    }
}