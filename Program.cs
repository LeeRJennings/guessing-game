using System;
using System.Collections.Generic;

Random r = new Random();
int secretNumber = r.Next(1, 101);
Console.WriteLine($"The secret number is: {secretNumber}");

int guessFunc() 
{
    Console.Write("Guess a number ");
    string userGuess = Console.ReadLine();
    int usersGuessParsed = int.Parse(userGuess);
    return usersGuessParsed;
}

int difficultySelection()
{
    Console.WriteLine("Select a difficulty");
    Console.WriteLine("1) Easy");
    Console.WriteLine("2) Medium");
    Console.WriteLine("3) Hard");
    string userDifficultyINput = Console.ReadLine();
    int selectedDifficulty = int.Parse(userDifficultyINput);

    if(selectedDifficulty == 3) 
    {
        return 3;
    }
    else if (selectedDifficulty == 2)
    {
        return 5;
    }
    else if (selectedDifficulty == 1) 
    {
        return 7;
    }
    else 
    {
        return 0;
    }
};

int userDifficulty = difficultySelection();
int guess = guessFunc();
int count = 0;

while(count != userDifficulty)
{
    if (guess == secretNumber) 
    {
        Console.WriteLine("You got it!");
        break;
    }
    else 
    {
        count++;
        if (guess > secretNumber) 
        {
            Console.WriteLine("That guess was too high.");
        }
        else if (guess < secretNumber)
        {
            Console.WriteLine("That guess was too low.");
        }
        Console.WriteLine($"Guesses left: {userDifficulty - count +1}");
    }
    guess = guessFunc();
}
