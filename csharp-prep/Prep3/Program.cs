using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        /* 
        Console.Write("What is the magic number? ");
        string magicNumberString = Console.ReadLine();
        int magicNumber = int.Parse(magicNumberString);
        */
        string replay = "yes";
        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,100);

            int userGuessInt;

            do
            {
                Console.Write("What is your guess? ");
                string userGuess = Console.ReadLine();
                userGuessInt = int.Parse(userGuess);

                if (userGuessInt < magicNumber)
                {
                    Console.WriteLine("Higher");
                }

                else if (userGuessInt > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.Write("Would you like to play again? ");
                    replay = Console.ReadLine();
                } 

            } while (userGuessInt != magicNumber);
        } while (replay == "yes");

        Console.WriteLine("Thank you for playing!");
    }
}


/* 
Teacher's Example:

using System;

class Program
{
    static void Main(string[] args)
    {
        // For Parts 1 and 2, where the user specified the number...
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        
        // For Part 3, where we use a random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        // We could also use a do-while loop here...
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    
    }
}
*/