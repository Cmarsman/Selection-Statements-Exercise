﻿namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Number guessing Game
            var r = new Random();
            var favNumber = r.Next(1, 10);

            Console.WriteLine("Pick a number from 1 - 10");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            { 
            Console.WriteLine($"{userInput} is too low");
            }
            else if( userInput > favNumber) 
            {
                Console.WriteLine($"{userInput} is too high");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
