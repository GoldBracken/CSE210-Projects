using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment math = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(math.GetSummary());

        MathAssignment math2 = new MathAssignment("Roberto Rodriguez", "Fraction", "Section 7.3", "Problems 8-19");
        Console.WriteLine("\n" + math2.GetSummary());
        Console.WriteLine(math2.GetHomeworkList());

        WritingAssignment paper = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine("\n" + paper.GetSummary());
        Console.WriteLine(paper.GetWritingInformation());
    }
}