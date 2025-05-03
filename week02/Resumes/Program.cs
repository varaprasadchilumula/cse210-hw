using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Web and Graphic Designer";
        job1._company = "BeHungry, RFL Group Venture";
        job1._startYear = 2014;
        job1._endYear = 2016;

        Job job2 = new Job();
        job2._jobTitle = "Senior UI/UX Designer";
        job2._company = "DashNinja Technologies (AlohaABAIndia)";
        job2._startYear = 2016;
        job2._endYear = 2020;

        Resume myResume = new Resume();
        myResume._name = "Varaprasad Chilumula";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}