using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter in your grade percentage: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter = "F";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed, study harder.");
        }
        Console.WriteLine($"You got and {letter}");
    }
}