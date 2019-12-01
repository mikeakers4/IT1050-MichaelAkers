using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 types of control structures we use to order statements in our programs are selection statements, which consist of if, else, switch, and case branching,
            // iterations statements, which consists of do, for, foreach and while looping, and jump statements, which contains break, continue, return, and goto statements.

            bool keepLooping = true;
           while (keepLooping == true)
            {
               Console.WriteLine("This is an infinite loop");
          }

            int i = 2;
            while (i <= 128)
            {
                Console.WriteLine("[{0}]", i);
                i = i + i;
            }
            
            for (int number = 49; number > 0; number--)
            {
                if (number != 1)
                {
                    Console.Write("{0},", number);
                }
                else
                {
                    Console.Write("{0}", number);
                }
            }
            Console.WriteLine();

            int oddsLoop = 1;
            while (oddsLoop < 22)
            {
                if (oddsLoop % 2 == 1)
                {
                    Console.Write("{0} ", oddsLoop);
                }
                oddsLoop++;
            }

            // It outputs one asterisk.
            // If it used a while statement, it would not output anything.

            bool icyRain;
            bool tornadoWarning;

            icyRain = false;
            tornadoWarning = false;

            if (icyRain == false && tornadoWarning == false)
            {
                Console.WriteLine("Let's go outside!");
            }


            for (int j = 5; j > 0; j--)
            {
                for (int k = 1; k <= j; k++)
                {
                    Console.Write("{0}", k);
                }
                for (int k = j - 1; k > 0; k--)
                {
                    Console.Write("{0}", k);
                }
                Console.WriteLine();
            }

            string enterToEnd = Console.ReadLine();
        }
    }


}
