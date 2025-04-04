using System.Runtime.InteropServices;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");
        for (int i = 0; i<_jobs.Count; i++)
        {
            _jobs[i].DisplayJob();
            Console.WriteLine("");
        }
    }
}

/* Teacher's Example
using System;

public class Resume
{
    public string _name;

    // Make sure to initialize your list to a new List before you use it.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Notice the use of the custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            // This calls the Display method on each job
            job.Display();
        }
    }
}
*/