using System;

class ProgramJob
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "Soporte Global";
        job1._jobTitle = "Web Developer";
        job1._startYear = 2022;
        job1._endYear = 2026;

        Job job2 = new Job();

        job2._company = "Google";
        job2._jobTitle = "Seo Web Developer";
        job2._startYear = 2020;
        job2._endYear = 2022;

        Console.WriteLine($"{job1._company}");
        Console.WriteLine($"{job2._company}");

        job1.Display();

        Resume myResume = new Resume();

        myResume._name = "Yeampier Huerta";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}