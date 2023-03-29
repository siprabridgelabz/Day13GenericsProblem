using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13GenericsProblem
{
    public class MaxMethodFor3Parameters<T> where T : IComparable
    {
        public T[] value;
        public MaxMethodFor3Parameters(T[] values)
        {
            this.value = value;
        }

        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[1];
        }

        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }
        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("maximum value is " + max);
        }

        static void Main(string[] args )
        {
            int[] arr = { 121, 254, 263, 142 };
            MaxMethodFor3Parameters<int> generic = new MaxMethodFor3Parameters<int>(arr);
            generic.PrintMaxValue();
        }

       
 

        


    }
}
