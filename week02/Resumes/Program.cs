using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
    }

    public class Job
    {
        private string _jobTitle;
        private string _company;
        private int _startYear;
        private int _endYear;

        // Constructor to initialize the job
        public Job(string jobTitle, string company, int startYear, int endYear)
        {
            _jobTitle = jobTitle;
            _company = company;
            _startYear = startYear;
            _endYear = endYear;
        }

        // Method to display job details
        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
    }

    public class Resume
    {
        private string _name;
        private List _jobs;

        public Resume(string name)
        {
            _name = name;
            _jobs = new List();
        }

        public void AddJob(Job job)
        {
            _jobs.Add(job);
        }

        public void Display()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs:");
            foreach (var job in _jobs)
            {
                job.Display();
            }
        }
    }

class Program
{
    static void Main(string[] args)
    {
        // Create job instances
        Job job1 = new Job("Software Engineer", "Microsoft", 2019, 2022);
        Job job2 = new Job("Manager", "Apple", 2022, 2023);

        // Create a resume instance
        Resume myResume = new Resume("Allison Rose");
        
        // Add jobs to the resume
        myResume.AddJob(job1);
        myResume.AddJob(job2);

        // Display the resume
        myResume.Display();
    }
}
}
