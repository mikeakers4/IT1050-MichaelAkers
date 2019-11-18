using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. The four basic elements are the controlled variable, the initial value of the control variable, 
            //the increment of decrement by which the control variable is modfified each time through the loop known as iteration of the loop, and loop continuation condition, 
            //which determines whether to continue looping.

            //3. For repitition which specifies the elements of counter controlled repetition in a single line of code; 
            //in general counter controlled repetition should be implentmented with a for statement. A repetition statement 
            //allows you to specify that an app should repeat an action while some condition remains true.

            //4. In the while statements, the app tests the loop continuation condition at the beginning of the loop, before executing the loop's body. If the condition is false, the body doesn't execute. 
            //The do-while statement test the loops continuation condition after executing the loop's body, therefore the body always executes once.

            for (int i = 1; i <= 100; i++)
            {
                if ((i % 2) == 0)
                {

                    Console.WriteLine("it's even");

                }
                if ((i % 2) != 0)
                {

                    Console.WriteLine("it's odd");

                }
            }
            Console.WriteLine("Please input a temp");
            double temperature = Convert.ToDouble(Console.ReadLine());
            if (temperature < 10)
            {

                Console.WriteLine("Polar bear");

            }
            else if (temperature < 20)
            {
                Console.WriteLine("Penguin");

            }
            else if (temperature < 40)
            {
                Console.WriteLine("Moose");

            }
            else if (temperature < 50)
            {
                Console.WriteLine("Reindeer");

            }
            else if (temperature < 60)
            {
                Console.WriteLine("Deer");

            } else if (temperature < 70)
            {
                Console.WriteLine("Turtle");

            } else if (temperature < 80)
            {
                Console.WriteLine("Lion");

            } else if (temperature < 90)
            {
                Console.WriteLine("Fish");

            } else
            {
                Console.WriteLine("Bug");
            }
            // You're never changing the number below 21. 
            int j = 10;
            while (j < 21)
            {
                Console.WriteLine(j);
                j++;
            }

            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("********");
            }
        }
    }
}
