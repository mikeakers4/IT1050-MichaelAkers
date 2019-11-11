using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Single selection uses a single scenario, if condition is true it does it, etc. A while statement, it'll due it at least one time or again and again until it is not true.

            int speedLimit = 35;
            int speed = 42;

            if (speed > speedLimit)
            {
                Console.Out.WriteLine("SLOW NOW ");
            }

            bool isTrue = true;

            if (isTrue)
            {
                Console.Out.WriteLine("It is True!");
            }
            else
            {
                Console.Out.WriteLine("It is False!");
            }
            Console.Out.WriteLine("Please enter a temperature in fahrenheit");

            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32d) * 5d / 9d;
            Console.Out.WriteLine(celsius);
            if(fahrenheit < 40) {
                Console.WriteLine("It is cold");
            }
            if (fahrenheit > 90)
            {
                Console.WriteLine("It is hot");
            }
            int i = 1;

            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }



            int j = 60;

            while (j >= 20)
            {
                Console.WriteLine(j);
                j = j - 5;
            }


            int k = 10;

            while (k <= 20)
            {
                Console.WriteLine(k);
                k = k + 2;
            }
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
