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
//using System;

//class Program
//{
//    static void Main()
//    {
//        //string companyName = Console.ReadLine();
//        //string companyAddress = Console.ReadLine();
//        //ulong phoneNum = ulong.Parse(Console.ReadLine());
//        //string fax = Console.ReadLine();
//        //string web = Console.ReadLine();
//        //string firstNameManager = Console.ReadLine();
//        //string lastNameManager = Console.ReadLine();
//        //int age = int.Parse(Console.ReadLine());
//        //ulong phoneManager = ulong.Parse(Console.ReadLine());
//        //
//        //Console.WriteLine(companyName);
//        //Console.WriteLine("Address: {0}", companyAddress);
//        //Console.WriteLine("Tel. +" + "{0:### ### ## ## ##}", phoneNum);
//        //Console.WriteLine (fax == "" ? "Fax: (no fax)" : "Fax:" + fax);
//        //Console.WriteLine("Web site: {0}", web);
//        //Console.WriteLine("Manager: {0} {1} (age: {2}, tel. +{3:### # ### ###} )", firstNameManager, lastNameManager, age,phoneManager);

//        string str1 = (Console.ReadLine()); //Company name
//        string str2 = (Console.ReadLine()); //Company address
//        string str3 = (Console.ReadLine()); //Phone number
//        string str4 = (Console.ReadLine()); //Fax number
//        string str5 = (Console.ReadLine()); //Web site
//        string str6 = (Console.ReadLine()); //Manager first name
//        string str7 = (Console.ReadLine()); //Manager last name
//        string str8 = (Console.ReadLine()); //Manager age
//        string str9 = (Console.ReadLine()); //Manager phone

//        string output1 = str1;
//        string output2 = ("Address: " + str2);
//        string output3 = ("Tel. " + str3);
//        string output4 = ((str4 == "") ? "Fax: (no fax)" : ("Fax: " + str4));
//        string output5 = ("Web site: " + str5);
//        string output6 = ("Manager: " + str6);
//        string output7 = str7;
//        string output8 = ("age: " + str8);
//        string output9 = ("tel. " + str9);

//        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5} {6} ({7}, {8})", output1, output2, output3, output4, output5, output6, output7, output8, output9);

//    }
//}

