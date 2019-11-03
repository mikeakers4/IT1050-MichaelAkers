using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int product;

            Console.Write("Enter first int: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second int: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            product = number1 * number2;
            Console.WriteLine("product is {0}", product);

            Console.WriteLine("(0)\n(1)", "Hello World!", "From Mike Akers");
            Console.WriteLine("(0)\t(1)", "Hello World!", "From Mike Akers");

           /*
            * Our C# program executes on line 11, the main function, and starts with declaring variables and then getting 
            * user input and doing our product calculation and outputting hello world.
            * 
            * An integer type variable store numbers in a limited range of real number precisely and floating point 
            * variables store approximations of real numbers across a wider range.
            * 
            * public void DisplayMessage(string CourseName)
            * (
            * Console.WriteLine("Welcome to the grade book for \n(o)!", courseName);
            * )
            * 
            * Get accessor, Set Accessor.
            * 
            * A class is used to house a message while an object is an instance of the class. You can create as many instances 
            * of a class as each one has a different object.
            */
        }
    }
}
