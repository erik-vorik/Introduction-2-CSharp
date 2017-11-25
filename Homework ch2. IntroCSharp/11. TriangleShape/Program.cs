using System;


    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            char a = (char)'\u00A9';
            //string b = System.Convert.ToString(a);
            //string triangle = @" b;
            //char[] array = new char[] { };
            //Console.WriteLine(triangle);
            Console.WriteLine("   {0}    \n " +
                              " {0} {0}  \n " +
                              "{0}   {0} \n"  +
                            "{0} {0} {0} {0}",   (char)'\u00A9');
            Console.WriteLine((a).GetType() + " е променливата с която изчертаваме малкият триъгълник");


            Console.WriteLine("                       \u00A9\u00A9\u00A9\u00A9\u00A9\u00A9\u00A9\u00A9\u00A9\u00A9\u00A9\u00A9\u00A9\u00A9\u00A9\u00A9\u00A9 ");
            Console.WriteLine("                        \u00A9             \u00A9 ");
            Console.WriteLine("                         \u00A9           \u00A9 ");
            Console.WriteLine("                          \u00A9         \u00A9 ");
            Console.WriteLine("                           \u00A9       \u00A9 ");
            Console.WriteLine("                            \u00A9     \u00A9 ");
            Console.WriteLine("                             \u00A9   \u00A9 ");
            Console.WriteLine("                              \u00A9 \u00A9 ");
            Console.WriteLine("                               \u00A9");
            Console.WriteLine((a).GetType() + " е променливата с която изчертаваме големият триъгълник");





        }
    }

