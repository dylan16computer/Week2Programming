using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1B
{
    public class ProgramTask1B
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(MultiplyNums(num1, num2));
        }
        public static int MultiplyNums(int num1, int num2)
        {
            return (num1 * num2);
        }
    }
}