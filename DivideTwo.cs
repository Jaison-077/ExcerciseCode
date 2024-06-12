using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseCode
{
    internal class DivideTwo
    {
        public void printProgram()
        {
            int num1, num2, divide;
            Console.Write("Enter the Number : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Divide by : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            divide = num1 / num2;

            Console.WriteLine($"Result: {divide}");
        }
    }
}
