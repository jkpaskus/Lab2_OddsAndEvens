using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////input
            //DateTime input;
            //Console.Write("Enter a number between 1 and 100: ");
            //input = DateTime.Parse(Console.ReadLine());

            //if (input.Year < 1000)
            //{
            //    Console.WriteLine("This date is in the first Mill.");
            //}
            //else if (input.Year < 2000)
            //{
            //    Console.WriteLine("This date is in the second Mill.");
            //}
            //else
            //{
            //    Console.WriteLine("This date is in the third Mill.");
            //}

            //-------------------------------------------------------------------------------------

            int i;
            Console.Write("Enter a number between 1 and 100: \n");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Entered Number is {0} and even", i);
                Console.Read();
            }
            else
            {
                Console.Write("Entered Number is {0} and odd", i);
                Console.Read();
            }
        }
    }
}
