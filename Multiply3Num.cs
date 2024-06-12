using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseCode
{
    internal class Multiply3Num
    {
        public void printProgram()
        {
            int a, b, c,result;
            Console.Write("Enter the First Num: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Second Num: ");
            b = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the Thrid Num: ");
            c = Convert.ToInt32(Console.ReadLine());

            result = a*b*c;
            Console.WriteLine($"Multiply of three: {result}");
        }
    }
}
