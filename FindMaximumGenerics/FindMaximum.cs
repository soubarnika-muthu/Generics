using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumGenerics
{
    public class FindMaximum<T> where T : IComparable
    {
        public T firstVal, secondVal, thirdVal;

        public FindMaximum(T first, T second, T third)
        {
            this.firstVal = first;
            this.secondVal = second;
            this.thirdVal = third;
        }

        public static T FindMax(T firstVal, T secondVal, T thirdVal)
        {
            if (firstVal.CompareTo(secondVal) > 0 && firstVal.CompareTo(thirdVal) > 0)
            {
                return firstVal;
            }
            else if (secondVal.CompareTo(firstVal) > 0 && secondVal.CompareTo(thirdVal) > 0)
            {
                return secondVal;
            }
            else
            {
                return thirdVal;
            }
        }

        public T MaxMethod()
        {
            T max = FindMaximum<T>.FindMax(this.firstVal, this.secondVal, this.thirdVal);
            return max;
        }
    }
}
