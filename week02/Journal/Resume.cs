using System;

class Program
{
    static void Main(string[] args)
    {
    public class Resume
    {
        public string Name { get; set; }
        public List<Job> Jobs { get; } = new List<Job>();

        public Resume(string name)
        {
            Name = name;
        }

        public void AddJob(Job job)
        {
            Jobs.Add(job);
        }
    }
}
}