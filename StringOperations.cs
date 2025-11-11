using System;

class StringOperations
{
    static void Main()
    {
        Console.WriteLine("=== String Operations ===");
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine($"Uppercase: {input.ToUpper()}");
        Console.WriteLine($"Lowercase: {input.ToLower()}");
        Console.WriteLine($"Length: {input.Length}");
        Console.WriteLine($"Reversed: {ReverseString(input)}");
    }

    static string ReverseString(string str)
    {
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}
