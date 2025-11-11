using System;

class ArraySorting
{
    static void Main()
    {
        Console.WriteLine("=== Array Sorting ===");
        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            arr[i] = Convert.ToInt32(Console.ReadLine());

        Array.Sort(arr);

        Console.WriteLine("Sorted Array:");
        foreach (int num in arr)
            Console.Write(num + " ");
    }
}
