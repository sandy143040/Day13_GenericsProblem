using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    public class TestMaximum<T> where T : IComparable
    {
        private List<T> values;

        public TestMaximum(params T[] values)
        {
            this.values = new List<T>(values);
        }

        public T FindMax()
        {
            if (values.Count == 0)
            {
                throw new InvalidOperationException("No values provided.");
            }

            T max = values[0];

            foreach (T value in values)
            {
                if (value.CompareTo(max) > 0)
                {
                    max = value;
                }
            }

            return max;
        }
    }
}
