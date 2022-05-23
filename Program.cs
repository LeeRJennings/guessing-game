using System;
using System.Collections.Generic;

Random r = new Random();
int secretNumber = r.Next(1, 101);
// Console.WriteLine($"The secret number is: {secretNumber}");

int guessFunc() 
{
    Console.Write("Guess a number: ");
    string userGuess = Console.ReadLine();
    int usersGuessParsed = int.Parse(userGuess);
    return usersGuessParsed;
}

int captureDifficulty()
{
    Console.WriteLine("Select a difficulty");
    Console.WriteLine("1) Easy");
    Console.WriteLine("2) Medium");
    Console.WriteLine("3) Hard");
    Console.WriteLine("4) Cheater");
    string userDifficultyINput = Console.ReadLine();
    int difficulty = int.Parse(userDifficultyINput);
    return difficulty;
}

int difficultySelection()
{
    int selectedDifficulty = captureDifficulty();

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
    else if (selectedDifficulty == 4)
    {
        return -1;
    }
    else 
    {
        return difficultySelection();
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
        if (userDifficulty != -1) 
        {
            Console.WriteLine($"Guesses left: {userDifficulty - count + 1}");
        }
        guess = guessFunc();
    }
    
    if (count == userDifficulty && guess != secretNumber)
    {
        Console.WriteLine($"You didn't get it. The secret number was {secretNumber}");
    }
    else if (count == userDifficulty && guess == secretNumber)
    {
        Console.WriteLine("You got it!");
    }
}
