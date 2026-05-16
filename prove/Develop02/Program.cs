using System.IO;

// I added a feature that tracks the number of days since you last wrote in your journal.
// If the user has written for 2 or more consecutive days, it compliments them on their consistency.
// This feature is found in the Journal Class found in Journal.cs

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("\n Journal Menu:");
            Console.WriteLine("1. New Entry");
            Console.WriteLine("2. Read Entries");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("Chose an option: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Entry entry = new Entry();
                entry.DisplayEntryPrompt();
                
                journal.AddEntry(entry);
            }

            else if (choice == 2)
            {
                journal.DisplayAllEntries();
            }

            else if (choice == 3)
            {
                Console.Write("\nEnter filename (Do not include .txt): ");

                string responseFile = Console.ReadLine();
                string appendedTxt = ".txt";
                string cleanFile = responseFile + appendedTxt;

                journal.Save(cleanFile);
            }

            else if (choice == 4)
            {
                Console.Write("\nEnter filename (Do not include .txt): ");

                string responseFile = Console.ReadLine();
                string appendedTxt = ".txt";
                string cleanFile = responseFile + appendedTxt;

                journal.Load(cleanFile);

                journal.CheckReminder();
            }

        }
    }
}