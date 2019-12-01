using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fill in the blanks: p[0], p[1], [p2], p[3]

            string[] months = new string[12];
            months[0] = "January";
            months[1] = "February";
            months[2] = "March";
            months[3] = "April";
            months[4] = "May";
            months[5] = "June";
            months[6] = "July";
            months[7] = "August";
            months[8] = "September";
            months[9] = "October";
            months[10] = "November";
            months[11] = "December";

            for (int j = 0; j < 12; j++)
            {
                Console.WriteLine(j + 1);
                Console.WriteLine(months[j]);
            }
            string[] seasons = new string[4];
            seasons[0] = "Spring";
            seasons[1] = "Summer";
            seasons[2] = "Fall";
            seasons[3] = "Winter";

            foreach (string season in seasons)
            {
                Console.Write($"{season} ");
            }

            int[] numbers = new int[1000];
            Random random = new Random();
            int randomNumber;

            for (int j = 0; j < 1000; j++)
            {
                randomNumber = random.Next(0, 100);
                numbers[j] = randomNumber;
            }
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int i = 0;
            while (i < names.Length)
            {
                Console.WriteLine(names[i]);
                Console.WriteLine("{0,2}, {1}", i, names[i]);
                i++;
            }
            i = 0;
            foreach (string name in names)
            {
                Console.WriteLine("{0,2}, {1}", i, name);
                i++;
            }
        }
    }
}

