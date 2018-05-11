using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Review
            //string name = "Emmalani Bryan";
            //int age = 35;


            //// Start Here //
            ////Console.WriteLine("Emmalani Bryan");
            ////Console.WriteLine("Aloha "+ name);
            ////Console.WriteLine(name + " is " + age);
            //Console.WriteLine("{0} is {1}", name, age);  // 0 and 1 are place holders from above

            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Nic Torres";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();

            // Ask user's name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);

            // Init correct number
            int correctNumber = 7;

            // Init guess var
            int guess = 0;

            // Ask user for number
            Console.WriteLine("Guess a number between 1 and 10");

            // While guess is not correct
            while (guess != correctNumber)
            {
                // Get user input
                string input = Console.ReadLine();

                // Cast to int and put in guess
                guess = int.Parse(input);

                // Match guess to correct number
                if(guess != correctNumber)
                {
                    // Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Tell user the wrong number
                    Console.WriteLine("Wrong number, please try again");

                    // Reset text color
                    Console.ResetColor();
                }

            }

            // Output success message
            // Change text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Tell user it's the right number
            Console.WriteLine("You are CORRECT!!!");

            // Reset text color
            Console.ResetColor();

        }
    }
}
