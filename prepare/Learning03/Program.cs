using System;

class Program
{
    static void Main(string[] args)
    {
        
        Fraction first = new Fraction();
        
        Console.WriteLine(first.GetFractionString());
        Console.WriteLine(first.GetDecimalValue());

        Fraction second = new Fraction(5);
        
        Console.WriteLine (second.GetDecimalValue());
        Console.WriteLine (second.GetFractionString());

        Fraction third = new Fraction(3, 4);
        
        Console.WriteLine(third.GetFractionString());
        Console.WriteLine(third.GetDecimalValue());

        Fraction forth = new Fraction(1, 3);
        
        Console.WriteLine(forth.GetFractionString());
        Console.WriteLine(forth.GetDecimalValue());
        
        Fraction randomFraction = new Fraction();

        Random randomGenerator = new Random();

        int loopNumber = 0;

        while (loopNumber != 20)
        {
            loopNumber += 1;
            int top = randomGenerator.Next(1, 50);
            int bottom = randomGenerator.Next(1,50);

            randomFraction.SetTop(top);
            randomFraction.SetBottom(bottom);


            Console.WriteLine($"Fraction {loopNumber}:\nstring = {randomFraction.GetFractionString()}\nNumber = {randomFraction.GetDecimalValue()}\n");
        }

    }
}