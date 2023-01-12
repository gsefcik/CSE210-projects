using System;

class Program
{
    static void Main(string[] args)
    {   
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guessed = -1;

        while (guessed != number)
        {
            Console.Write("Please Guess a number between 1 & 100: ");
            guessed = int.Parse(Console.ReadLine());

            if (number > guessed)
            {
                Console.WriteLine("Too low, try a higher number");
            }
            else if (number < guessed)
            {
                Console.WriteLine("Too high, try a lower number");
            }
            else
            {
                Console.WriteLine("Amazing! You guessed it!");
            }

        }                    
    }
}
