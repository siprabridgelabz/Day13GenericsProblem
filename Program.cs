using Day13GenericsProblem;

namespace Day13GenericsProblems
{
    class Program
    {
        public static void toPrint<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
        }
       
        public static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'A', 'B', 'C', 'D', 'E' };

           
            Console.WriteLine("please enter the first value ");

            int num1 = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("please enter the second value ");

            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter the third value ");

            int num3 = Convert.ToInt32(Console.ReadLine());

            int val = MaxValue<int>.MaximumIntegerNumber(num1, num2, num3);

            Console.WriteLine("{0} is greater", val);
        }
    }
}

