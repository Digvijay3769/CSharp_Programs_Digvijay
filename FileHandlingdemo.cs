using System;
using System.IO;

class FileHandlingDemo
{
    static void Main()
    {
        string path = "sample.txt";
        Console.WriteLine("=== File Handling Demo ===");

        // Writing to file
        File.WriteAllText(path, "Hello, this is a sample file created using C#.");

        // Reading from file
        string content = File.ReadAllText(path);
        Console.WriteLine("File Content:");
        Console.WriteLine(content);
    }
}
