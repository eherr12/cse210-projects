using System;

public class job
{
    public string _jobtitle;
    public string _company;
    public int _startyear;
    public int _endyear;

    void Display()
    {
        Console.WriteLine($"{_jobtitle}({_company}){_startyear}-{_endyear}");
    }
}

