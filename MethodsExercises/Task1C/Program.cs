using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1C
{
    public class ProgramTask1C
    {
        public static void Main()
        {
            Math.MultiplyNums();
        }
    }
    public static class Math
    {
        public static void MultiplyNums()
        {
            Console.WriteLine("Please enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Printing from new class: " + num1 + " * " + num2 + " = " + (num1 * num2));
        }
    }
}
