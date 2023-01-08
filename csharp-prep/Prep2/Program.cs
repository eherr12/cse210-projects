using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your grade percentage?");
        string input=Console.ReadLine();
        int grade=int.Parse(grade);
        
        string letter="";

        if (grade>=90)
            {letter="A";
            }
        else if (grade>=80)
            {letter="B";
            }
        else if (grade>=70)
            {letter="C";
            }
        else if (grade>=60)
            {letter="D";
            }
        else (grade>=50)
            {letter="F";
            }
        Console.WriteLine($"Your letter grade is {letter}");
        if (grade>=70)
            {Console.WriteLine("You passed!");
            }
        else
            {"You did not pass the class. Sorry Try again."
            }
