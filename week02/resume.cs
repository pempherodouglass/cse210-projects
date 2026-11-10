using System;
using System.Collections.Generic; // Required to use List<>

public class Resume
{
    // Responsibilities
    public string _name;
    
    // Initialize the list right away as recommended in the instructions hint
    public List<Job> _jobs = new List<Job>(); 

    // Behaviors
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Iterate through each Job instance in the list and display them
        foreach (Job job in _jobs)
        {
            job.Display(); // Calls the Display method from your Job class
        }
    }
}
