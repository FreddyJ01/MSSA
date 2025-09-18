using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        //reading and writing strings
        string filePath = Path.Combine(Path.GetTempPath(), "sync-alltext.txt");
        File.WriteAllText(filePath, "Hello World");

        string content = File.ReadAllText(filePath);
        Console.WriteLine(content);

        //reading and writing bytes
        filePath = Path.Combine(Path.GetTempPath(), "sync-allbytes.txt");
        byte[] data = { 1, 2, 3, 4, 5 };

        File.WriteAllBytes(filePath, data);

        byte[] readData = File.ReadAllBytes(filePath);
        System.Console.WriteLine(string.Join(", ", readData));

        //reading and writing lines
        filePath = Path.Combine(Path.GetTempPath(), "sync-alllines.txt");
        string[] lines = { "First line", "Second line", "Third line" };

        File.WriteAllLines(filePath, lines);

        string[] readLines = File.ReadAllLines(filePath);
        foreach (string line in readLines)
        {
            System.Console.WriteLine(line);
        }

        //stream reader & writer
        filePath = Path.Combine(Path.GetTempPath(), "sync-stream.txt");
        string fullText = $"This is the first line{Environment.NewLine}This is the second line";

        WriteFullText(filePath, fullText);
        ReadFullText(filePath);

        WriteLines(filePath);
        ReadLines(filePath);

        WriteTextSync(filePath, fullText);
        ReadTextSync(filePath);

    }

    static void WriteFullText(string filePath, string text)
    {
        using StreamWriter writer = new StreamWriter(filePath, false, Encoding.Unicode);
        writer.Write(text);
    }

    static void ReadFullText(string filePath)
    {
        using StreamReader reader = new StreamReader(filePath, Encoding.Unicode);
        string content = reader.ReadToEnd();
        System.Console.WriteLine(content);
    }

    static void WriteLines(string filePath)
    {
        using StreamWriter writer = new StreamWriter(filePath, false, Encoding.Unicode);
        writer.WriteLine("Line 1");
        writer.WriteLine("Line 2");
    }

    static void ReadLines(string filePath)
    {
        using StreamReader reader = new StreamReader(filePath, Encoding.Unicode);
        string? line;
        while ((line = reader.ReadLine()) != null)
        {
            System.Console.WriteLine(line);
        }
    }

    static void WriteTextSync(string filePath, string text)
    {
        byte[] encodedText = Encoding.Unicode.GetBytes(text);

        using FileStream sourceStream = new FileStream(
        filePath,
        FileMode.Create, FileAccess.Write, FileShare.None,
        bufferSize: 4096, useAsync: false);

        sourceStream.Write(encodedText, 0, encodedText.Length);
    }

    static void ReadTextSync(string filePath)
    {
        using FileStream sourceStream = new FileStream(
            filePath,
            FileMode.Open, FileAccess.Read, FileShare.Read,
            bufferSize: 4096, useAsync: false
        );

        byte[] buffer = new byte[sourceStream.Length];
        int bytesRead = sourceStream.Read(buffer);
        string decodedText = Encoding.Unicode.GetString(buffer, 0, bytesRead);
        System.Console.WriteLine(decodedText);
    }
};