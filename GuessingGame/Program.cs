using System;

namespace GuessingGame
{
  class Program
  {
    static void Main(string[] args)
    {
      // Writing a console program that invites the user to guess a secret number
      // Create a variable to contain the secret number and a holding state for the user's guess
      int secretNumber = 42;
      int userGuess = 0;
      // Display a message to the user asking them to guess the secret number.
      Console.WriteLine("Welcome to Guessing Game");

      // In Phase 3, add the number of guesses to 4
      for (int i = 1; i <=4; i++)
      {
        // Display a prompt for the user's guess.
        Console.WriteLine("Guess the secret number");
        // Take the user's guess as input and save it as a variable.
        userGuess = Convert.ToInt32(Console.ReadLine());
        // Display the user's guess back to the screen. Hidden in Phase 2.
        // Console.WriteLine(userGuess);

        // Compare user's guess to the secret number and display an error or success message
        if (userGuess == secretNumber)
        {
          Console.WriteLine("Wow you got it correct!");
        }
        else
        {
          Console.WriteLine("Wrong guess, can you do anything right?");
        }
      }

    }
  }
}
