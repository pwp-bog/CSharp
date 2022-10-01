using System;
using System.Threading.Channels;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heightOfTriangles = int.Parse(Console.ReadLine());

            // for beautiful output in console
            Console.WriteLine("\n\n");

            for (int i = 0; i < heightOfTriangles; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("@");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n\n");

            for (int i = heightOfTriangles; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("@");
                }

                Console.WriteLine();
            }


            Console.WriteLine("\n\n");

            int zeroValueCounter = heightOfTriangles;

            for (int i = 0; i < heightOfTriangles; i++)
            {
                for (int j = zeroValueCounter - 1; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < i + 1; k++)
                {
                    Console.Write("@");
                }

                zeroValueCounter -= 1;
                Console.WriteLine();
            }

            Console.WriteLine("\n\n");

            zeroValueCounter = 0;

            for (int i = heightOfTriangles; i > 0; i--)
            {
                for (int j = zeroValueCounter; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < i; k++)
                {
                    Console.Write("@");
                }

                zeroValueCounter += 1;
                Console.WriteLine();
            }
        }
    }
}