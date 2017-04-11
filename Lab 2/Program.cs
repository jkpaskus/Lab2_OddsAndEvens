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
            //the run variable will control the do while loop
            bool run = true;


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

            do
            {
                Console.Write("Enter a number between 1 and 100: \n");
                i = int.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    Console.WriteLine("Entered Number is {0} and odd", i);
                    //Console.Read();
                }
                else
                {
                    if (i >= 2 && i < 25)
                    {
                        Console.WriteLine("Entered number is even and less than 25");
                    }
                    else if (i >= 26)
                    {
                        Console.WriteLine("Number is even!");
    //                    Console.Read();
                    }
                }

                Console.WriteLine("Do you want to continue?");

                string input = Console.ReadLine();
                    if (input.ToLower() == "no")
                    run = false;

            } while (run);
            }
     }
}