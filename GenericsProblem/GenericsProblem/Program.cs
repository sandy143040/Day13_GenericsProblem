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
            var firstVal = Console.ReadLine();
            Console.WriteLine( "Enter Second Value: ");
            var secondVal = Console.ReadLine();
            Console.WriteLine("Enter Third Value: ");
            var thirdVal = Console.ReadLine();
            TestMaximum testMaximum = new TestMaximum();
            testMaximum.FindMax(firstVal, secondVal, thirdVal);
       
            Console.ReadLine();
        }
    }
}
