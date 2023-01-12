using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string gpa = Console.ReadLine();

        int grade = int.Parse(gpa);
        
        if (grade >= 90)
        {
            Console.WriteLine ("You earned an A");
            Console.WriteLine ("***Congratulations!! You have passed the course!!***");
        }
        else if (grade >= 80)
        {
            Console.WriteLine ("You earned an B");
            Console.WriteLine ("***Congratulations!! You have passed the course!!***");
        }
        else if (grade >= 70)
        {
            Console.WriteLine ("You earned an C");
            Console.WriteLine ("***Congratulations!! You have passed the course!!***");
        }
        else if (grade >= 60)
        {
            Console.WriteLine ("You earned an D");
            Console.WriteLine ("Unfortunately you did not meet the requirements to pass this class. Please try again");
        }
        else if (grade >= 59)
        {
            Console.WriteLine ("You earned an F");
            Console.WriteLine ("Unfortunately you did not meet the requirements to pass this class. Please try again");
        }

            }
}