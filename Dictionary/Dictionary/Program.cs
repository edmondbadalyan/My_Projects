



using System;
using System.Collections.Generic;

class Program
{
    static void ProcessNumbers(IEnumerable<int> numbers)
    {
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    static void Main()
    {
        List<int> listNumbers = new List<int> { 1, 2, 3, 4, 5 };
        int[] arrayNumbers = new int[] { 6, 7, 8, 9, 10 };

        Console.WriteLine("Processing listNumbers:");
        ProcessNumbers(listNumbers);

        Console.WriteLine("Processing arrayNumbers:");
        ProcessNumbers(arrayNumbers);
    }
}
