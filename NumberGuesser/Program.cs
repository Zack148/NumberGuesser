using System;
using static System.Console;
using static System.Convert;
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
            GetAppInfo(); // Runs get AppInfo function

            GreetUser(); 

            while (true)
            {
            // Init correct number
            //int correctNum = 7;

            //Random Object
            Random random = new Random();

            int correctNum = random.Next(1, 11);

            // Init Guess Var
            int guess = 0;

            WriteLine("Guess a number between 1-10");

            // Loops through until users guesses correct number
            while (guess != correctNum)
            {
                // Get Users Input
                string input = ReadLine();

                // Checks for number and not letter

                if (!int.TryParse(input, out guess))
                {
                        //Print error message
                        PrintColorMessage(ConsoleColor.DarkRed, "Please use an actual number.");

                    continue;
                }

                // Cast to int 
                guess = Int32.Parse(input);

                // Match Guess
                if (guess != correctNum)
                {

                  PrintColorMessage(ConsoleColor.Red, "Wrong Number please try again.");
                }

            }

                PrintColorMessage(ConsoleColor.Yellow, "You are correct!.");

                // ask to play again
                WriteLine("Play again? [Y or N]");

                string answer = ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
            
        }

        // Get & Display App Info
        static void GetAppInfo()
        {
            // Variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Zack";

            // Change Text Color
            ForegroundColor = ConsoleColor.Green;


            // Writes App Info
            WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Resets Text Color
            ResetColor();
        }

        //Greets user
        static void GreetUser()
        {
            // Users Name
            WriteLine("What is your name?");

            string inputName = ReadLine();

            WriteLine("Hello {0}, let's play a game...", inputName);
        }

        //Print Color Message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change Text Color
            ForegroundColor = color;


            // Writes Error Message
            WriteLine(message);

            // Resets Text Color
            ResetColor();
        }

    }
}
