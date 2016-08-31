using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            Console.WriteLine("");
            string cont;
            do


            {
                Console.WriteLine("Enter the Length for Rectangle:");
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Enter the Width for Rectangle:");
                float b = float.Parse(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Area of rectangle is : " + a * b);

                Console.WriteLine("Perimeter of rectangle is: " + (2 * a + 2 * b));
                Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine("Do you want to continue? (y/n)");
                cont = Console.ReadLine();
                Console.WriteLine("");

            } while (cont == "y");
            Console.WriteLine("");

            Console.WriteLine("Goodbye!");
            Console.ReadLine();


        }
    }
}