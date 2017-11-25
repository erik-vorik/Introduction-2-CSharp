using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Spiral_Matrix
{
    class Program
    {
        static void Main()
        {

            Console.Write("Enter number :  ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            int x=0, y=-1;
            int k = 0;



           do
           {



                //stepping right
                for (y++; y < n && matrix[x, y]==0; y++)
                {

                    matrix[x, y] = ++k;

                }
                if (y>=n || matrix[x, y] != 0)
                {
                    y -= 1;
                }
                

                //stepping down
                for (x++; x < n && matrix[x, y] == 0; x++)
                {
                    matrix[x, y] = ++k;
                }
                if (x>=n || matrix[x, y] != 0)
                {
                    x -= 1;
                }
                

                //stepping left
                for (y--; y >= 0 && matrix[x, y] == 0; y--)
                {
                    matrix[x, y] = ++k;
                }
                if (y<0 || matrix[x, y] != 0)
                {
                    y += 1;
                }
                

                //stepping up
                for (x--; matrix[x, y] == 0; x--)
                {
                    matrix[x, y] = ++k;
                }
                if (matrix[x, y] != 0)
                {
                    x += 1;
                }
                

           } while (k<n*n);


            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
