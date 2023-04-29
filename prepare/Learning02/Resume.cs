public class Resume
{
    public string _name = "Marvellous Chirunga";
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }

    }

}

public class Certificate
{
    public string _title = " ";
    public string _certifyingBody = " ";
    public int _Year = 2020;
    public int _expYear = 2025;

    public void DisplayCertificationDetails()
    {
        Console.WriteLine($"{_title} ({_certifyingBody}) {_Year}-{_expYear}");
    }
    
} 
