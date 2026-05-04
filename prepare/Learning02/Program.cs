using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2023;
        job1._endYear = 2026;

        Console.WriteLine(job1._company);

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "AI Engineer";
        job2._startYear = 2020;
        job2._endYear = 2024;
        
        Console.WriteLine(job2._company);

        job1.Display();
        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "John Smith";
        myResume._jobs = [job1, job2];

        myResume.Display();

    }
}