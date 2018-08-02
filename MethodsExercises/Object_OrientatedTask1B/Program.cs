using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_OrientatedTask1B
{
    class Program
    {
        static void Main(string[] args)
        {
            Person2 employee1 = new Person2("John Smith");
            Person2 employee2 = new Person2("Sebastian Hastings");
            Person2 employee3 = new Person2("Romeo Juliet");
            Person2 employee4 = new Person2("Janet Otago");
            Person2 employee5 = new Person2("Bruce Almighty");

            Console.WriteLine(employee1);

            //List<Person2> NameList = new List<Person2>
            //{
            //    employee1, employee2, employee3, employee4, employee5
            //};
            //foreach(Person2 employees in NameList)
            //{
            //    Console.WriteLine(employees.Name);
            //}
        }
    }
}
