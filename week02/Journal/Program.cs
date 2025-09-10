using System;

class Program
{
    static void Main(string[] args)
    {
        // Personal Data
        PersonalData pd = new PersonalData
        {
            FullName = "Melinda Respeto",
            Address = "Manila, Philippines",
            Age = 25,
            Email = "melinda.respeto@email.com",
            Phone = "+63 912 345 6789"
        };

        // Education
        Education edu1 = new Education
        {
            Degree = "Bachelor of Science in Computer Science",
            School = "University of the Philippines",
            YearGraduated = 2020
        };

        // Jobs
        Job job1 = new Job
        {
            JobTitle = "Teacher Assistant",
            Company = "Department of Education",
            StartYear = 2022,
            EndYear = 2024,
            Description = "Assisted lead teachers in classroom activities, student support, and lesson planning."
        };

        Job job2 = new Job
        {
            JobTitle = "Software Developer",
            Company = "Tech Solutions Inc.",
            StartYear = 2020,
            EndYear = 2022,
            Description = "Developed and maintained web applications, improved performance, and collaborated with cross-functional teams."
        };

        // Resume
        Resume resume = new Resume(pd.FullName);
        resume.AddEducation(edu1);
        resume.AddJob(job1);
        resume.AddJob(job2);
        resume.AddSkill("C# Programming");
        resume.AddSkill("Web Development (HTML, CSS, JavaScript)");
        resume.AddSkill("Database Management");
        resume.AddSkill("Problem Solving & Critical Thinking");

        // Display Resume
        pd.DisplayPersonalData();
        resume.DisplayResume();
    }
}