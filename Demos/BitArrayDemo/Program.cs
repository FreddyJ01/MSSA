namespace BitArrayDemo;

class Program
{
    static void Main(string[] Args)
    {
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