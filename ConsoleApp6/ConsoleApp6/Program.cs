


using System.Collections;
using System.Collections.Generic;

internal class Solution
{
    public static void Main(string[] arghs)
    {
        int[] nums = { 2, 7, 9, 3, 1 };
        int prevMax = 0;
        int currMax = 0;

        foreach (int num in nums)
        {
            int temp = currMax;
            currMax = Math.Max(prevMax + num, currMax);
            prevMax = temp;
        }

        Console.WriteLine(currMax);

    }


}