using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Value: ");
            int firstVal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Value: ");
            int secondVal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Value: ");
            int thirdVal = Convert.ToInt32(Console.ReadLine());

            TestMaximum<int> testMaximum = new TestMaximum<int>(firstVal, secondVal, thirdVal);
            testMaximum.MaximumValue();

            Console.ReadLine();
        }
    }
}
