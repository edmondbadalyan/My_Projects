using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLabors = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            int[] stages = new int[numLabors];

            for (int i = 0; i < numLabors; i++)
            {
                stages[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < numLabors - 1; i++)
            {
                
                sum += stages[i + 1] - stages[i];
            }

            Console.WriteLine($"{sum}");

        }
    }
}