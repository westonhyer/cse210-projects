using System;

class Program
{
    static void Main(string[] args)
    {
        string exit = "";
        Console.Clear();

        Reference reference = new Reference("John", 3, 3, 5);
        Scripture scripture = new Scripture(reference, 
                            "3. Jesus answered and said unto him, Verily, verily, I say unto thee, Except a man be born again, he cannot see the kingdom of God. " +

                            "4. Nicodemus saith unto him, How can a man be born when he is old? can he enter the second time into his mother’s womb, and be born? " +

                            "5. Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.");

        Console.WriteLine(scripture.GetDisplayTxt() + "\n\nPress enter to continue or type 'quit' to exit.");

        while (exit.ToLower() != "quit")
        {
            exit = Console.ReadLine();
            Console.Clear();         
            scripture.HideWords(3);            
            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Environment.Exit(0);
            }            
            Console.WriteLine(scripture.GetDisplayTxt() + "\n\nPress enter to continue or type 'quit' to exit.");
        }
    }
}