using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse
{
    internal class Dotryparse
    {


        static void Main(string[] args)
        {
            bool TryParse(string input, out int result)
            {
                try
                {
                    result = int.Parse(input);
                    return true;
                }
                catch (Exception)
                {
                    result = 0;
                    return false;
                }

            }
            static void multiprint( params int[] values)
            {
                foreach (int value in values)
                {
                    Console.WriteLine(value);
                }

            }



            Console.WriteLine("give me integer number");
            string input = Console.ReadLine();

            if (TryParse(input, out int result))
            {
                Console.WriteLine($"Success, {result}");
            }
            else
            {
                Console.WriteLine($"error,{result}");
            }


            multiprint(1,2,3,4,5);
            

            

            


        }







    }
}
