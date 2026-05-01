using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        return number;
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.WriteLine("What year were you born?");
        string userInput = Console.ReadLine();
        birthYear = int.Parse(userInput);
    }

    static int SquareNumber(int y)
    {
        int squared = y * y;

        return squared;
    }

    static void DisplayResult(string name, int squared, int birthYear)
    {
        int age = 2026 - birthYear;
        Console.WriteLine($"{name}, the square of your number is {squared}");
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
    static void Main(string[] args)
    {
        int birthYear = 1000;
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        PromptUserBirthYear(out birthYear);
        int squared = SquareNumber(number);
        DisplayResult(name, squared, birthYear);
    }
}