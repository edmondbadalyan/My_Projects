using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());


for (int i = A; i <= B; i++)
{
    Console.Write(i);
    Console.Write(i);

    for (int j = A; j <= i; j++)
    {
        Console.Write(i);
    }

    Console.WriteLine();
}

