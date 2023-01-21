using System;

public class resume
{
    public string _name;
    public List<job> _jobs=new list<job>();
    public void Display()
    {

        Console.WriteLine($"name:{_name}");
        Console.WriteLine("Jobs:");

        foreach (job job in _jobs)
        {
            
        job.display();
        }
    }

}
