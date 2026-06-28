using System;

class Program
{
    static GoalManager manager = new GoalManager();
    static void Main(string[] args)
    {
        bool running = true;
        
            while (running)
            {
                Console.WriteLine();
                Console.WriteLine("Eternal Quest");
                Console.WriteLine("=============");
                manager.DisplayScore();
                Console.WriteLine();
                Console.WriteLine("1. Create new goal");
                Console.WriteLine("2. List goals");
                Console.WriteLine("3. Record event");
                Console.WriteLine("4. Save goals");
                Console.WriteLine("5. Load goals");
                Console.WriteLine("6. Quit");
                Console.Write("Select a choice: ");
 
                string choice = Console.ReadLine();
                Console.WriteLine();
 
                switch (choice)
                {
                    case "1":
                        CreateGoal();
                        break;
                    case "2":
                        manager.ListGoals();
                        Console.Write("When you are ready to continue, press enter.");
                        Console.ReadLine();
                        break;
                    case "3":
                        RecordEvent();
                        break;
                    case "4":
                        Console.Write("File name to save to: ");
                        manager.Save(Console.ReadLine());
                        break;
                    case "5":
                        Console.Write("File name to load from: ");
                        manager.Load(Console.ReadLine());
                        break;
                    case "6":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("That's not a valid choice. Please try again.");
                        break;
                }
            }
 
            Console.WriteLine("Goodbye!");
        }
 
        private static void CreateGoal()
        {
            Console.WriteLine("What type of goal would you like to create?");
            Console.WriteLine("1. Simple goal (completed once)");
            Console.WriteLine("2. Eternal goal (never complete)");
            Console.WriteLine("3. Checklist goal (complete a set number of times)");
            Console.Write("Select a choice: ");
            string typeChoice = Console.ReadLine();
 
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
 
            Console.Write("What is a short description of this goal? ");
            string description = Console.ReadLine();
 
            Console.Write("How many points is this goal worth? ");
            int points = int.Parse(Console.ReadLine());
 
            switch (typeChoice)
            {
                case "1":
                    manager.AddGoal(new SimpleGoal(name, description, points));
                    break;
                case "2":
                    manager.AddGoal(new EternalGoal(name, description, points));
                    break;
                case "3":
                    Console.Write("How many times must this goal be accomplished to complete it? ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for completing this goal? ");
                    int bonus = int.Parse(Console.ReadLine());
                    manager.AddGoal(new ChecklistGoal(name, description, points, target, bonus));
                    break;
                default:
                    Console.WriteLine("That's not a valid goal type. No goal was created.");
                    return;
            }
 
            Console.WriteLine("Goal created!");
        }
 
        private static void RecordEvent()
        {
            manager.ListGoals();
            Console.Write("Which goal did you accomplish? (enter the number) ");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                manager.RecordEvent(index);
            }
            else
            {
                Console.WriteLine("That's not a valid number.");
            }
        }
    }