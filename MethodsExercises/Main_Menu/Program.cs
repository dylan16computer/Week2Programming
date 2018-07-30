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
                Console.WriteLine("Enter a number between 1 and 4 for its corresponding program: ");
                int programNum = int.Parse(Console.ReadLine());
                switch (programNum)
                {
                    case 1:
                        Message(programNum);
                        ProgramTask1A.Main();
                        break;
                    case 2:
                        Message(programNum);
                        ProgramTask1B.Main();
                        break;
                    case 3:
                        Message(programNum);
                        ProgramTask1C.Main();
                        break;
                    case 4:
                        Message(programNum);
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
        static void Message(int programNum)
        {
            Console.WriteLine("{0}{1}{2}","Program ", programNum, " has been chosen.");
        }
    }
}
