// Created by: Alex Nelson
// Created on: Nov 2022
//
// This program allows you to guess a hidden number
using System;

class Program
{
    public static void Main(string[] args)
    {
        //Input
        int guessValue;
        //Returns an `int` value greater in the range 1 <= value <7
        Random rd = new Random();
        int randomNumber = rd.Next(1,7);
        Console.WriteLine("This program allows you to guess a hidden number");
        Console.WriteLine("");
        Console.WriteLine("Guess a number between 1 and 6: ");
        guessValue = Convert.ToInt32(Console.ReadLine());
        //Output
        Console.WriteLine("");
        if(guessValue == randomNumber)
        {
            Console.WriteLine("Correct! " + randomNumber + " was the right number!" );
        }
        if(guessValue != randomNumber)
        {
            Console.WriteLine("incorrect! The correct number was " + randomNumber + ". Restart and try again!");
        }
        Console.WriteLine("\nDone");
    }
}
