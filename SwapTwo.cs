using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseCode
{
    internal class SwapTwo
    {
        public void printProgram()
        {
            int a, b;
            Console.WriteLine("Enter First Number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            b= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Before Swapping : a = {a}, b = {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"After Swapping : a = {a}, b = {b}");
        }
    }
}
