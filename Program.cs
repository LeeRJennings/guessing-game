using System;
using System.Collections.Generic;

int secretNumber = 42;

int guessFunc() 
{
    Console.WriteLine("Guess a number");
    string userGuess = Console.ReadLine();
    int usersGuessParsed = int.Parse(userGuess);
    return usersGuessParsed;
}

int guess = guessFunc();
int count = 1;

while(count < 4)
{
    if (guess == secretNumber) 
    {
        Console.WriteLine("You got it!");
        break;
    }
    else 
    {
        Console.WriteLine("Nah dude, try again.");
        count++;
    }
    guess = guessFunc();
}
