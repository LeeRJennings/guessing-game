using System;
using System.Collections.Generic;

Random r = new Random();
int secretNumber = r.Next(1, 101);
Console.WriteLine(secretNumber);

int guessFunc() 
{
    Console.WriteLine("Guess a number");
    string userGuess = Console.ReadLine();
    int usersGuessParsed = int.Parse(userGuess);
    return usersGuessParsed;
}

int guess = guessFunc();
int count = 3;

while(count != 0)
{
    if (guess == secretNumber) 
    {
        Console.WriteLine("You got it!");
        break;
    }
    else 
    {
        Console.WriteLine("Nah dude, try again.");
        count--;
        Console.WriteLine($"Guesses left: {count +1}");
    }
    guess = guessFunc();
}
