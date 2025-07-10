using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._company = "Google";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Data Scientist";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Joyce Keil";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        Console.WriteLine($"Name: {myResume._name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in myResume._jobs)
        {
            job.DisplayJobDetails();
        }
        
    }

    
    }