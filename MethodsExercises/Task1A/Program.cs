using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1A
{
    public class ProgramTask1A
    {
        public static void Main()
        {
            MultiplyNums();
        }
        public static void MultiplyNums()
        {
            Console.WriteLine("Please enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
        }
    }
}