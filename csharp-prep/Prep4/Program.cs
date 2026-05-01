using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");
        int number = 1;
        List<int> numbers = new List<int>();
        int sum = 0;
        int largest = 0;

        while (number != 0)
        {
            
            Console.WriteLine("Enter Number: "); 
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        foreach (int entry in numbers)
        {
            sum += entry;

            if (entry > largest)
            {
                largest = entry;
            }
        }

        int length = numbers.Count;
        float average = sum / length;
        Console.WriteLine($"The Sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

    }
}