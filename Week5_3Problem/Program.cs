using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week5_3
{

    class Program
    {
        public static void Main(string[] args)

        {
            ProblemOne();
            ProblemTwo();
            ProblemFour();
           
        }
        public static void ProblemOne()
        {
            int count = 0;

            for (var i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine("{0} numbers 0 thru 100  can be dived by 3", count);
        }
        public static void ProblemTwo()
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number (or 'ok' to exit program):  ");
                var userInput = Console.ReadLine();

                if (userInput.ToLower() == "ok")
                {
                    break;
                }
                else
                {
                    sum += Convert.ToInt32(userInput);
                }
            }
            Console.WriteLine("Sum of all numbers equals: " + sum);
        }
        public static void ProblemFour()
        {
            var randomNumber = new Random().Next(1, 10);

            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine("Guess the Mystery Number between 1 and 10: ");
                var chance = Convert.ToInt32(Console.ReadLine());
                if (chance == randomNumber)
                {
                    Console.WriteLine("You WIN!!!!");
                    return;
                }
            }
            Console.WriteLine("YOU LOSE!!!!\nThe number was {0}", randomNumber);
        }



    }
}











