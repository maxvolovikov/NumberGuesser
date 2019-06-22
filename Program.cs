using System;

namespace NumberGuesser
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            GetAppInfo(); //run get app info func

            string userName = GreetUser();


            while(true)
            {
                //initial correct number
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                //initial guess number
                int guessNumber = 0;

                //ask a user for a guess
                Console.WriteLine("Dear {0}, guess a number between 1 and 10 please", userName);
                Console.WriteLine();

                //while guess is not coorect
                while (guessNumber != correctNumber)
                {
                    //get users input
                    string input = Console.ReadLine();

                    //check if input is a number
                    if (!int.TryParse(input, out guessNumber))
                    {
                        //change text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        //app info stamp
                        Console.WriteLine("My dear {0}, do you know what numbers are? {1} is not a NUMBER! Try again", userName, guessNumber);

                        //reset console color
                        Console.ResetColor();

                        //keep going
                        continue;
                    }

                    //cast to integer and put to guessNumber
                    guessNumber = Int16.Parse(input);

                    //check if the guess is correct
                    if (guessNumber != correctNumber)

                    {
                        //change text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        //app info stamp
                        Console.WriteLine("My dear {0}, you are upsetting me {1} is not a correct guess! I will give you another try, but please try harder!", userName, guessNumber);

                        //reset console color
                        Console.ResetColor();
                    }
                }

                //output the confirmation of the right guess
                //change text color
                Console.ForegroundColor = ConsoleColor.Yellow;

                //app info stamp
                Console.WriteLine("My dear {0}, you must be psychic {1} is a correct guess!", userName, guessNumber);

                //reset console color
                Console.ResetColor();

                //ask if user wants to play again
                Console.WriteLine(@"Are you enjoying my game? You DO want to play again, right?
[Y or N]");
                //collect continue answer
                string toContinue = Console.ReadLine().ToUpper();

                //check answer
                if(toContinue == "Y")
                {
                    continue;
                }
                else if(toContinue =="N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

            
        }
        //get app information
        static void GetAppInfo()
        {
            //app stamp values
            string appName = "Guess My Number";
            string appVersion = "1.0.0";
            string appAuthor = "MaxVol";

            //change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //app info stamp
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //reset console color
            Console.ResetColor();
        }

        //get user name and greet 
        static string GreetUser()
        {
            //ask name
            Console.WriteLine();
            Console.WriteLine("What is your name Stranger?");

            //read input val
            var userName = Console.ReadLine();

            //greet user
            Console.WriteLine();
            Console.WriteLine(@"Good day to you {0}, welcome to my game!", userName);
            Console.WriteLine();

            return (userName);
        }
    }
}
