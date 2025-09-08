using System;
using System.Collections.Generic;

namespace ResumeApp
{
    
    public class Resume
    {
       
        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value ?? string.Empty; // avoid null names
        }

        public List<Job> Jobs { get; } = new List<Job>();

        
        public Resume() { }

        
        public Resume(string name)
        {
            _name = name ?? string.Empty;
        }

        
        public void AddJob(Job job)
        {
            if (job == null) throw new ArgumentNullException(nameof(job));
            Jobs.Add(job);
        }
    }
}
