using System;



    class PointInACircle
    {
        static void Main()
        {
            Console.WriteLine("Enter the coordinates of point O (x,y)");
            Console.WriteLine("x=");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("y=");
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine(((x * x) + (y * y)) <= 25 ? "The point is in the circle" : "The point is OUT of the circle");
        }
    }
    

