// Resume Class Constructor
public class Resume
{
    // member variables: string _name, List<Job> _jobs
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // overloaded ToString() method is called when instance of Resume class is called as a string.
    // Returns: string display
    public override string ToString()
    {
        string display = $"Name: {_name}\nJobs:\n";

        // loops through all jobs in _jobs list and appends them to the display string
        foreach (Job job in _jobs)
        {
            display += job + "\n";
        }

        return display;
    }
}