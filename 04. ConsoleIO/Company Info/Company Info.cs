using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Info
{
    class Program
    {

        static void Main(string[] args)
        {
            long a = 0;
            long phoneNumber;
            string faxNumber = "\0";
            long managerPhone;
            string managerAge;


            Console.Write("Company name:  ");
            string companyName = Console.ReadLine();

            Console.Write("Company address:  ");
            string companyAddress = Console.ReadLine();

            Console.Write("Phone number:  ");
            phoneNumber = long.Parse(Console.ReadLine()); ;

            Console.Write("Fax number:  ");
            if (!long.TryParse(Console.ReadLine(), out a))
            {
                faxNumber = "(no fax)";
            }

            Console.Write("Web site:  ");
            string webSite = Console.ReadLine();

            Console.Write("Manager First name :  ");
            string managerFirst = Console.ReadLine();

            Console.Write("Manager Last name :  ");
            string managerLast = Console.ReadLine();

            Console.Write("Manager age :  ");
            do
            {
                managerAge = Console.ReadLine();
            } while (!long.TryParse(managerAge, out a));

            Console.Write("Manager phone :  ");
            managerPhone = long.Parse(Console.ReadLine());
            Console.WriteLine(managerPhone);


            Console.WriteLine("\n\n\n");


            //-----------------------------------------------
            Console.WriteLine("{0,-1}", companyName);
            Console.WriteLine("Address: {0,-1}", companyAddress);
            Console.WriteLine("Tel. {0,1:+### ### ## ## ###}", phoneNumber);
            Console.WriteLine("Fax: {0,-1}", faxNumber);
            Console.WriteLine("Website: {0,-1}", webSite);
            Console.WriteLine("Manager: {0,-1} {1,-1} (age:{2,-1}, tel.{3,-1:+### ### ###}) ", managerFirst, managerLast, managerAge, managerPhone);









        }
    }
}
