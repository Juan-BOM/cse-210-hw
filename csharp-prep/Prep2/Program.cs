using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string gradeFromUser = Console.ReadLine();
        int gradeFromUserNumber = int.Parse(gradeFromUser);
        string letter = "";

        if (gradeFromUserNumber >= 70)
        {
            if (gradeFromUserNumber >= 90)
            {
                letter = "A";
            }

            else if (gradeFromUserNumber >= 80)
            {
                letter = "B";
            }

            else if (gradeFromUserNumber >= 70)
            {
                letter = "C";
            }

            Console.WriteLine($"You earned a(n) {letter}.You have passed the course!");
        }

        else
        {
            if (gradeFromUserNumber >= 60)
            {
                letter = "D";
            }

            else
            {
                letter = "F";
            }

            Console.WriteLine($"You earned a {letter}. You did not pass the course, please try again next semester!");
        }
    }   
}


/* Teacher's Example
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}
*/