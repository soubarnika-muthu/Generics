using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
        class PrintArray<T>
        {
            public T[] inputArray;
            public PrintArray(T[] inputArray)
            {
                this.inputArray = inputArray;
            }
            //Printing the array using generic type T
            public void ToPrintArray()
            {
                Console.WriteLine("======Printing Array======");
                foreach (var i in this.inputArray)
                {
                    Console.WriteLine(i);
                }
            }


        }
}

