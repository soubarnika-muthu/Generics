using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding maximum of Given numbers  using test cases ");
            double[] array = { 1.1, 1.3, 5.6, 5.36, 6.2, 80.5, 1 };
            double maxdouble = new FindMaximum<double>(array).MaxMethod();
            
            char[] arraychar = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
            char maxChar = new FindMaximum<char>(arraychar).MaxMethod();
            int[] arrayint = { 10, 5, 100, 85, 96, 2, 1 };
            int maxInt = new FindMaximum<int>(arrayint).MaxMethod();


        }
    }
}
