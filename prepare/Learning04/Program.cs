using System;

class Program
{
    static void Main(string[] args)
    {
       Console.Clear();
       MathAssignment assignment = new MathAssignment("Section 3.14", "Problems 7-12", "Jeff Jefferson", "Math");
       Console.WriteLine(assignment.GetSummary());
       Console.WriteLine(assignment.GetHomeworkList());
       Console.WriteLine();
       
       WrittingAssignment writting = new WrittingAssignment("My Thoughts", "Bob Bobbertson", "Creative Writting");

       Console.WriteLine(writting.GetSummary());
       Console.WriteLine(writting.GetWrittingInformation());
    }
}