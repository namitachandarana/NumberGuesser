using System;
using System.Net;

//namespace is a container that holds classes and functions
namespace NumberGuesser
{

    // This course was done from your tube:https://www.youtube.com/watch?v=GcFJjpMFJvI
    //Creates a basic app. use Ctrl+F9 to run the program
    class Program
    {
        static void Main(string[] args)
        {/*
            string name = "Namita";
            int age = 30;
            Console.WriteLine(name + " is " + age);
            //Using Placeholder is to print
            Console.WriteLine("{0} is {1}", name, age);
            */
            //Set app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Namita";
            //Change Text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Verison {1} by {2}", appName, appVersion, appAuthor);

            //Reset Test Color
            Console.ResetColor();

            // Ask users name
            Console.WriteLine("what is your name?");

            //Get the user input
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, lets play a game..", inputName);

            while (true)
            {

                // Init Set correct number 
                //int correctNumber = 7;

                //create a new random object
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                //Init guess variable
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    //Get the user input
                    string input = Console.ReadLine();

                    //Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        //Change Text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        //Tell user its not a number
                        Console.WriteLine("Please enter an actual number");

                        //Reset Test Color
                        Console.ResetColor();

                        //Keep going
                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Change Text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        //Tell user its the wrong number
                        Console.WriteLine("Wrong number, please try again");

                        //Reset Test Color
                        Console.ResetColor();
                    }
                }

                // Output success message
                //Change Text color
                Console.ForegroundColor = ConsoleColor.Yellow;

                //Tell user its the right number
                Console.WriteLine("You are correct!!!!!!");

                //Reset Test Color
                Console.ResetColor();


                //Ask to play again
                Console.WriteLine("Play Again? [ Y or N ]");


                string answer = Console.ReadLine().ToUpper();

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
    }
}
