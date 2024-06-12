using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseCode
{
    internal class SumOfTwo
    {
        public void printProgram()
        {
            int num1, num2,sum;
            Console.Write("Enter the first Number : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Second Number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2;

            Console.WriteLine($"Result: {sum}");
        }
    }
}
