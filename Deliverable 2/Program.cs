using System;

public class Program
{
    public static void Main()
    {
        //Here are some variables I can use to keep track of heads, tails,
        //the round, and the total number of flips the user guessed correctly.
        //I realized after I wrote the code that I'm not actually doing anything with
        //The total number of Heads and Tails, but I'm going to keep it anyway.
        int Heads = 0;
        int Tails = 0;
        int Correct = 0;
        int Round = 0;

        //Found this random number generation on Stack Overflow for
        //a coin flip game someone else was working on.
        Random CoinFlip = new Random();
        

        Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
        Console.WriteLine("What is your name?");
        string Username = Console.ReadLine();
        Console.WriteLine("Welcome " + Username + ". Do you want to do the COIN FLIP CHALLENGE? Yes/No");
        string Response = Console.ReadLine();

        //Not entirely sure how this line works, but it does.
        //I'll ask about it later.
        bool BeginGame = Response == "Yes";
        if (BeginGame == false)
        {
            Console.WriteLine("You are a coward, " + Username + ".");
        }
        else
        {

            //Found this bit on Stack Overflow too and managed to make it fit my code.
            for (Round = 0; Round < 5; Round++)
            {
                int Flip = CoinFlip.Next(0, 2);
                Console.WriteLine("Heads or Tails?");
                string Guess = Console.ReadLine();

                if (Guess == "Heads" && Flip == 1)
                {
                    Console.WriteLine("Correct!");
                    Heads++;
                    Correct++;
                }
                else if (Guess == "Heads" && Flip == 0)
                {
                    Console.WriteLine("Wrong!");
                    Tails++;
                }
                else if (Guess == "Tails" && Flip == 1)
                {
                    Console.WriteLine("Wrong!");
                    Tails++;
                    Correct++;
                }
                else if (Guess == "Tails" && Flip == 0)
                {
                    Console.WriteLine("Correct!");
                    Tails++;
                }
            }
            Console.WriteLine("Thank you for playing, " + Username + ". Your score is " + Correct + ".");
        }
    }
}