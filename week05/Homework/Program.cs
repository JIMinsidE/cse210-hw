using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a MathAssignment instance
        MathAssignment mathAssignment = new MathAssignment("John Atkinsonn", "Algebra", "Section 5.2", "Problems 1-10");
        Console.WriteLine(mathAssignment.GetHomeworkList());

        // Create a WritingAssignment instances
        WritingAssignment writingAssignment = new WritingAssignment("Jane Smith", "Literature", "The Great Gatsby Essay");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}