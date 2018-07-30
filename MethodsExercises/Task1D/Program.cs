using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1D
{
    public class ProgramTask1D
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 1 to add OR 2 to substract OR 3 to divide: ");
            int numberChoice = int.Parse(Console.ReadLine());
            switch(numberChoice)
            {
                case 1:
                    Math.Addition(num1, num2);
                    break;
                case 2:
                    Math.Subtraction(num1, num2);
                    break;
                case 3:
                    Math.Division(num1, num2);
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
    public static class Math
    {
        public static void Addition(int num1, int num2)
        {
            Console.WriteLine("Addition: " + (num1 + num2));
        }
        public static void Subtraction(int num1, int num2)
        {
            Console.WriteLine("Subtraction: " + (num1 - num2));
        }
        public static void Division(int num1, int num2)
        {
            Console.WriteLine("Division: " + (num2 / num1));
        }
    }
}
