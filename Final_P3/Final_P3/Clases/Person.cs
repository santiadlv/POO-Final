using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_P3.Clases
{
    public static class Person
    {
        public static string name;
        public static string lastname;

        public static void askName()
        {
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("\nPlease enter your last name: ");
            lastname = Console.ReadLine();

            try
            {
                if (name.Length > 2 && lastname.Length > 2)
                    Console.WriteLine("\nYour name and lastname is valid. Continue.");
                else
                    throw new LengthException();
            }
            catch (LengthException)
            {
                Console.WriteLine("\nInvalid name and/or last name. Please try again.");
            }
        }
    }
}
