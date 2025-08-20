namespace ConsoleApp1;
using System.Collections;
using System.Dynamic;

class Program
{
    static void Main(string[] Args)
    {
        ArrayList list = new ArrayList();
        list.Add("apple");

        System.Console.WriteLine(list[0]);

        BitArray bits = new BitArray(5);
        bits[0] = true;
        bits[2] = true;

        foreach (Boolean bit in bits)
        {
            System.Console.WriteLine(bit);
        }

        bits.Not();

        foreach (Boolean bit in bits)
        {
            System.Console.WriteLine(bit);
        }
    }
}