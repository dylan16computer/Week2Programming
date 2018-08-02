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

            foreach(Person1 employee in List1)
            {
                Console.WriteLine(employee.Fname);
                Console.WriteLine(employee.Lname);
                Console.WriteLine(employee.PayRate);
                Console.WriteLine(employee.Tax);
                Console.WriteLine(employee.AccountNumber);
            }
        }
    }
}
