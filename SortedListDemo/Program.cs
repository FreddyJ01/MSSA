namespace SortedListDemo;

class Program
{
    static void Main(string[] Args)
    {
        SortedList productPrices = new SortedList();
        productPrices.Add(102, 19.99);
        productPrices.Add(101, 6.99);
        productPrices.Add(103, 14.99);

        System.Console.WriteLine("Product prices sorted by product ID");

        foreach (DictionaryEntry product in productPrices)
        {
            System.Console.WriteLine(product.Value);
        }

        double price = (double)productPrices[101];
        System.Console.WriteLine($"\nPrice of product 102: {price}");
    }
}
