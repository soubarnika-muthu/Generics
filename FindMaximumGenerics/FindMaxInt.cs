using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumGenerics
{
    public class FindMaxInt
    {
        //Finding maximum of three integers
        public int FindMax(int firstVal, int secondVal, int thirdVal)
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
        //Finding maximum of three float numbers
        public static double FindMax(double firstVal, double secondVal, double thirdVal)
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
        //Finding maximum of three string values 
        public static string FindMax(string firstVal, string secondVal, string thirdVal)
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
    }
}
