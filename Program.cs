using System;
using System.Collections.Generic;

int secretNumber = 42;

Console.WriteLine("Guess a number");
string userGuess = Console.ReadLine();

int usersGuessParsed = int.Parse(userGuess);

if (usersGuessParsed == secretNumber) 
{
    Console.WriteLine("You got it!");
}
else 
{
    Console.WriteLine("Nah dude, try again.");
}