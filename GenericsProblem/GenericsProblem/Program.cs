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
            string firstVal = Console.ReadLine();
            Console.WriteLine( "Enter Second Value: ");
            string secondVal = Console.ReadLine();
            Console.WriteLine("Enter Third Value: ");
            string thirdVal = Console.ReadLine();
            TestMaximum testMaximum = new TestMaximum();
            string max = testMaximum.MaxString(firstVal, secondVal, thirdVal);
            Console.WriteLine("{0} is Largest string ", max);
            Console.ReadLine();
        }
    }
}
