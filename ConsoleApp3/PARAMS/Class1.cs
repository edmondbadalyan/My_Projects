using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PARAMS
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            
            
            try {
                ArrayOfInt a = new ArrayOfInt(null);
            } 
            catch (Exception e) {
                Console.WriteLine(e);
            }




        }


        class ArrayOfInt
        {

            private int[] array = new int[] {1,2,3,4,5,};
            public ArrayOfInt(int[] array)
            {   if(array == null)
                    throw new ArgumentNullException(nameof(array));
                this.array = array;
            }

        }

        //public static int Sum(params int[] number)
        //{
        //    int sum = 0;
        //    foreach (int i in number)
        //    {
        //        sum += i;
        //        return sum;
        //    }
        //}
    }
}
