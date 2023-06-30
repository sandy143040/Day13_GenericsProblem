using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    public class TestMaximum
    {
        public float MaxFloat(float firstNum, float secondNum, float thirdNum)
        {
            //TestCase-I
            if(firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0 ||
                firstNum.CompareTo(secondNum) >= 0 && firstNum.CompareTo(thirdNum) > 0 ||
                firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) >= 0)
            {
                return firstNum;
            }
            //TestCase-II
            if (secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) > 0 ||
                secondNum.CompareTo(firstNum) >= 0 && secondNum.CompareTo(thirdNum) > 0 ||
                secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) >= 0)
            {
                return secondNum;
            }
            //TestCase-III
            if (thirdNum.CompareTo(firstNum) > 0 && thirdNum.CompareTo(secondNum) > 0 ||
                thirdNum.CompareTo(firstNum) >= 0 && thirdNum.CompareTo(secondNum) > 0 ||
                thirdNum.CompareTo(firstNum) > 0 && thirdNum.CompareTo(secondNum) >= 0)
            {
                return thirdNum;
            }
            return firstNum;
        }
    }
}
