using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1830 Palmyra Dr", "Kirkland", "Ohio", "USA");
        Address address2 = new Address("1099 Wall St.", "New York", "New York", "USA");
        Address address3 = new Address("2319 Univeristy Blvd.", "Aneheim", "California", "USA");

        Lecture lecture1 = new Lecture("C# Syntax - Discovering the DOTNET Framework",
                                       "Lecture",
                                       "7/24/26",
                                       "10:00AM",
                                       address1,
                                       "Bill Gates",
                                       150);
        OutdoorGathering outdoorGathering1 = new OutdoorGathering("Hyer Family Reunion",
                                                                  "Outdoor Gathering",
                                                                  "7/17/26",
                                                                  "3:00PM",
                                                                  address2,
                                                                  "Partly Cloudy");
        Reception reception1 = new Reception("Johnson Wedding",
                                             "Reception",
                                             "8/6/26",
                                             "7:00PM",
                                             address3,
                                             "johnsonwedding@gmail.com");

        Console.WriteLine(lecture1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("-----------------------------------");
        Console.WriteLine();
        Console.WriteLine(outdoorGathering1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("-----------------------------------");
        Console.WriteLine();
        Console.WriteLine(reception1.GetFullDetails());
    }
}