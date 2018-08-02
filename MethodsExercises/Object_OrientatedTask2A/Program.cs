using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_OrientatedTask2A
{
    class Program
    {
        static void Main(string[] args)
        {
            Person2 employee1 = new Person2("John", "Smith", 20, 15, 10, "Builder", "9am - 5pm", "Married", "4 children", "New Zealand");
            List<Person2> List2 = new List<Person2>
            {
                employee1
            };
            foreach(Person2 employee in List2)
            {
                Console.WriteLine(employee1.Fname);
                Console.WriteLine(employee1.Lname);
                Console.WriteLine(employee1.PayRate);
                Console.WriteLine(employee1.Tax);
                Console.WriteLine(employee1.AccountNumber);
                Console.WriteLine(employee1.Occupation);
                Console.WriteLine(employee1.WorkHours);
                Console.WriteLine(employee1.)
                Console.WriteLine(employee1.Country);
            }
        }
    }
}
