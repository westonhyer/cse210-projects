using System;

class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("Welcome to the number guessing game!");
    Random randomGenerator = new Random();
    int magicNumber = randomGenerator.Next(1,100);
    int guess = 100000;
    string userInput = "";
    int guessNumber = 0;

    while (guess != magicNumber)
        {
            Console.WriteLine("Guess a number between 1 and 100");
            userInput = Console.ReadLine();
            guess = int.Parse(userInput);

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher.");
            }

            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower.");
            }
            guessNumber += 1;
        }
    Console.WriteLine($"You guessed it in {guessNumber} guesses!");

    }
}