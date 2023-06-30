using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    public class TestMaximum
    {
        public T FindMax<T>(T firstVal, T secondVal, T thirdVal) where T : IComparable
        {
            if (firstVal.CompareTo(secondVal) >= 0 && firstVal.CompareTo(thirdVal) >= 0)
            {
                Console.WriteLine("{0} is greater number out of {1} {2} {3}", firstVal, firstVal, secondVal, thirdVal);
                return firstVal;
            }
            else if (secondVal.CompareTo(firstVal) >= 0 && secondVal.CompareTo(thirdVal) >= 0)
            {
                Console.WriteLine("{0} is greater number out of {1} {2} {3}", secondVal, firstVal, secondVal, thirdVal);
                return secondVal;
            }
            else
            {
                Console.WriteLine("{0} is greater number out of {1} {2} {3}", thirdVal, firstVal, secondVal, thirdVal);
                return thirdVal;
            }
        }
    }
}
