/// Week 4 Lab 2		
///
/// @author: Julian Trupe
/// Date:  September 13, 2021
///
/// Problem Statement: Write a console application to simulate the lamp flowchart from lecture
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt the user to enter yes/no questions about the lamp
/// 3) If/else statements to determine next action
/// 4) Determine message to user based on answers
/// 


using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oh no! The lamp isn't working!");
            Console.WriteLine("Is the lamp plugged in? (y/n) ");
            string userInput = Console.ReadLine();
            if(userInput == "y" || userInput == "Y" || userInput.StartsWith("y") || userInput.StartsWith("Y"))
            {
                Console.WriteLine("Is the bulb burned out? (y/n) ");
                userInput = Console.ReadLine();
                if (userInput == "y" || userInput == "Y" || userInput.StartsWith("y") || userInput.StartsWith("Y"))
                {
                    Console.WriteLine("Get a new light bulb!");
                } else
                {
                    Console.WriteLine("You need to repair the lamp");
                }
            } else
            {
                Console.WriteLine("Plug the lamp in!");
            }
        }
    }
}
