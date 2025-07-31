namespace ConsoleApp1;
 
using System;
using System.ComponentModel.Design;
 
class Program
{
    static void Main()
    {
        string pangram = "The quick brown fox jumps over the lazy dog";
        string[] words = pangram.Split(' ');
        char[] letters;
        pangram = "";

        foreach (string word in words)
        {
            letters = word.ToCharArray();
            pangram += string.Join("", letters.Reverse()) + " ";
        }

            System.Console.WriteLine(pangram);
    }
}