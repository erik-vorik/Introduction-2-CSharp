using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_and_last_names
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your name and last name each on different rows");
            string Firstname = Console.ReadLine();
            string Lastname = Console.ReadLine();
            Console.WriteLine(" your first name is  " + Firstname + " and last name is " + Lastname);
        }
    }
}
