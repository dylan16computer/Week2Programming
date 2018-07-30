using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_MenuTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program is looping through each of the four methods.");
            string userInput;
            do
            {
                Circles.GetCircleValues();
                Circles.CalcCircleArea();
                Squares.GetSquareValues();
                Squares.CalcSquareArea();
                Console.WriteLine("Program is looping through each of the four methods. Type C to continue OR S to stop.");
                userInput = Console.ReadLine();
            } while (userInput == "C");
        }
    }
    class Circles
    {
        public static void GetCircleValues()
        {
            Console.WriteLine("GetCircleValues method");
        }
        public static void CalcCircleArea()
        {
            Console.WriteLine("CalcCircleArea method");
        }
    }
    class Squares
    {
        public static void GetSquareValues()
        {
            Console.WriteLine("GetSquareValues method");
        }
        public static void CalcSquareArea()
        {
            Console.WriteLine("CalcSquareArea method");
        }
    }
}
