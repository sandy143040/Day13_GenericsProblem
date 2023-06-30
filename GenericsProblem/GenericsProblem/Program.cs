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
            float firstVal = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine( "Enter Second Value: ");
            float secondVal = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Third Value: ");
            float thirdVal = Convert.ToSingle(Console.ReadLine());
            TestMaximum testMaximum = new TestMaximum();
            float max = testMaximum.MaxFloat(firstVal, secondVal, thirdVal);
            Console.WriteLine("{0} is Largest Number ", max);
            Console.ReadLine();
        }
    }
}
