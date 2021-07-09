using System;

namespace Generics
{
    class Program
    {
        /// <summary>
        /// UC1- Printing different array without generic type
        /// UC2- Printing array using generic type method
        /// UC3- Printig Array using generic class
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Printing array of different data type");
            int[] intArray = { 1,3,6,9 };
            double[] doubleArray = { 5.5,6.6,8.36, 6.2, 80.5, 1 };
            char[] charArray = { 'w', 'e', 'l', 'c', 'o', 'm', 'e' };
            new PrintArray<int>(intArray).ToPrintArray();
            new PrintArray<double>(doubleArray).ToPrintArray();
            new PrintArray<char>(charArray).ToPrintArray();
            Console.Read();
        }
    }
}
