using System;
using System.Security.Cryptography.X509Certificates;
using Homework;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment1 = new Assignment("John Doe", "Math Homework");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathAssignment1 = new MathAssignment("Jane Smith", "Algebra", "Section 5.2", "Problems 1-10");
        Console.WriteLine(mathAssignment1.GetSummary
        ());
        Console.WriteLine(mathAssignment1.GetHomeworkList());
            WritingAssignment writingAssignment1 = new WritingAssignment("Alice Johnson", "Essay on Climate Change", "Climate Change Impacts");
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
    }

  
}