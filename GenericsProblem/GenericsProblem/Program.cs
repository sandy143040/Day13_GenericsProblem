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
            // Test case with integers
            TestMaximum<int> intTestMaximum = new TestMaximum<int>(5, 10, 7, 12);
            int maxInt = intTestMaximum.FindMax();
            Console.WriteLine("Max integer value: " + maxInt);

            // Test case with floats
            TestMaximum<float> floatTestMaximum = new TestMaximum<float>(3.5f, 2.1f, 4.8f, 1.9f);
            float maxFloat = floatTestMaximum.FindMax();
            Console.WriteLine("Max float value: " + maxFloat);

            // Test case with strings
            TestMaximum<string> stringTestMaximum = new TestMaximum<string>("apple", "banana", "orange", "mango");
            string maxString = stringTestMaximum.FindMax();
            Console.WriteLine("Max string value: " + maxString);

            Console.ReadLine();
        }
    }
}
