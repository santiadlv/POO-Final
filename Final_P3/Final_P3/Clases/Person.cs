using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_P3.Clases
{
    class Person
    {
        public static string name;
        public static string lastname;

        public Person(string name, string lastname)
        {
            
        }

        public static void askName()
        {
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("\nPlease enter your last name: ");
            lastname = Console.ReadLine();            
        }
    }
}
