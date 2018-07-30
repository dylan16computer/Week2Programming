using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1A;
using Task1B;
using Task1C;
using Task1D;

namespace Main_MenuTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            do
            {
                Console.WriteLine("Enter 1 for program 1 OR 2 for program 2 OR 3 for program 3 OR 4 for program 4: ");
                int programNum = int.Parse(Console.ReadLine());
                switch (programNum)
                {
                    case 1:
                        ProgramTask1A.Main();
                        break;
                    case 2:
                        ProgramTask1B.Main();
                        break;
                    case 3:
                        ProgramTask1C.Main();
                        break;
                    case 4:
                        ProgramTask1D.Main();
                        break;
                    default:
                        Console.WriteLine("ERROR. Invalid input.");
                        break;
                }
                Console.WriteLine("Enter C to continue looping OR S to stop the program");
                userInput = Console.ReadLine();
            } while (userInput == "C");
        }
    }
}
