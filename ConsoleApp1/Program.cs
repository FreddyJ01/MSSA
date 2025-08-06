namespace ConsoleApp1;
using System;
using System.ComponentModel.Design;
 
class Program
{
    static void Main()
    {
        // String Interpolation Formatting
        int invoiceNumber = 1201;
        decimal productShares = 25.4568m;
        decimal subtotal = 2750.00m;
        decimal taxPercentage = .15825m;
        decimal total = 3185.19m;

        System.Console.WriteLine($"Invoice Number: {invoiceNumber}");
        System.Console.WriteLine($"Shares: {productShares:f3} Product");
        System.Console.WriteLine($"Subtotal: {subtotal:C}");
        System.Console.WriteLine($"Tax: {taxPercentage:P2}");
        System.Console.WriteLine($"Total billed: {total:C}");

        // Padding and Alignment
        string input = "Pad this";
        System.Console.WriteLine(input.PadLeft(12));
        
    }
}
