using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class PrintArray
    {
        //Printing the array using generic type T
        public static void ToPrintArray<T>(T[] inputArray)
        {
            Console.WriteLine("======Printing Array======");
            foreach (var i in inputArray)
            {
                Console.WriteLine(i);
            }
        }


        public static void ReadInput()
        {
            int[] intArray = { 2,6,5,7,833,55,66};
            double[] doubleArray = { 1.1, 2,5, 5.6, 7.8, 80.5, 1 };
            char[] charArray = { 'w','e' ,'l','c','o','m','e'};
            ToPrintArray(intArray);
            ToPrintArray(doubleArray);
            ToPrintArray(charArray);
        }





    }
}

