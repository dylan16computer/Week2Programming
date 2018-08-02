using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_OrientatedTask1A
{
    class Program
    {
        static void Main(string[] args)
        {
            Person1 employee1 = new Person1();
            employee1.Fname = "John";
            employee1.Lname = "Smith";
            employee1.PayRate = 20;
            employee1.Tax = 15;
            employee1.AccountNumber = 10;

            List<Person1> List1 = new List<Person1>
            {
                employee1
            };

            Console.WriteLine(employee1.Fname);
            Console.WriteLine(employee1.Lname);
            Console.WriteLine(employee1.PayRate);
            Console.WriteLine(employee1.Tax);
            Console.WriteLine(employee1.AccountNumber);
        }
    }
}
