using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Best Buy";
        job1._jobTitle = "Sales Associate";
        job1._startYear = 2020;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "AutoZone";
        job2._jobTitle = "Comercial Account Manager";
        job2._startYear = 2022;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._name = "Weston Hyer";
        myResume.DisplayResume();
    }
}