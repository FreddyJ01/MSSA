namespace AAA;

internal class Operations
{
    public static int Sum(int num1, int num2)
    {
        return (num1 + num2);
    }
}
class Program
{
    static void Main()
    {
        int[] arr = { 1, 22, 3, 4, 52, 6, 7 };
        int[] newArr = new int[arr.Length + 1];
        int insertIndex = 3;
        int newValue = 99;

        for (int i = 0; i < insertIndex; i++)
            newArr[i] = arr[i];

        newArr[insertIndex] = newValue;

        for (int i = insertIndex; i < arr.Length; i++)
            newArr[i + 1] = arr[i];

        foreach (int num in newArr)
            Console.WriteLine(num);

        int[] newerArr = new int[arr.Length - 1];
        int deleteIndex = 2;

        for (int i = 0; i < newerArr.Length; i++)
        {

            if (i == deleteIndex)
            {
                // newerArr[i] 
            }

            newerArr[i] = arr[i];
        }
        
        System.Console.WriteLine();

        foreach (int num in newerArr)
        {
            System.Console.WriteLine(num);
        }

    }
}
