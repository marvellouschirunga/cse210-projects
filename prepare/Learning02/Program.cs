using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._company = "Riverbird Technology Partners";
        job1._jobTitle = "Integration Specialist";
        job1._startYear = 2022;
        job1._endYear = 2024;
        job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._company = "Bloomberg";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2024;
        job2._endYear = 2026;
        job2.DisplayJobDetails();

        Job job3 = new Job();
        job3._company = "Microsoft";
        job3._jobTitle = "Software Engineer II";
        job3._startYear = 2027;
        job3._endYear = 2030;
        job3.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);
        myResume._jobs[0].DisplayJobDetails();
        myResume.DisplayResume();
    }

    
}