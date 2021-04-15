using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
          // Writing a console program that invites the user to guess a number
          // Display a message to the user asking them to guess the secret number.
            Console.WriteLine("Welcome to Guessing Game");
            Console.WriteLine("Guess the secret number");
            string userGuess = Console.ReadLine();
            Console.WriteLine(userGuess);
        }
    }
}
