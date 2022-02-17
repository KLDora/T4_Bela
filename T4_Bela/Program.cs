// Programmers: Team Hotel - Gabrielle Cox, Karissa Dora, Winston Leaphart,
// Dragana Nikic, Dante Poe, Claire Taylor, and Uliana Tretyakova
// Due Date: February 24, 2022
// Assignment: T4 Team Bela Problem on Kattis
// Description: Calculation of points based on playing cards and their respective suits.

using System;

namespace T4_Bela
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read user input 
            string line = Console.ReadLine();
            // Finding if space is present within the string
            int space = line.IndexOf(' ');
            // Converting to int by parsing from first element [0] and multiplyng by 4 to have a hand
            int hands = int.Parse(line.Substring(0, space)) * 4;
            // Adding space to remaning lines of user's input
            char suit = line[space + 1];
            // Declare variable for points 
            int points = 0;
            // Reads the number of suits in hand
            for (int i = 0; i < hands; i++)
            {
                // Reads the input from user
                string s = Console.ReadLine();
                // Executes the calculation of points depending on their card type.
                switch (s[0])
                {
                    case 'A':
                        points += 11;
                        break;
                    case 'K':
                        points += 4;
                        break;
                    case 'Q':
                        points += 3;
                        break;
                    // Declares suit type and dominance
                    case 'J':
                        // If suit is dominant, then 20
                        if (s[1] == suit)
                            points += 20;
                        // If suit is not dominant, then 2
                        else
                            points += 2;
                        break;
                    case 'T':
                        points += 10;
                        break;
                    case '9':
                        // If suit is dominant, then 14
                        if (s[1] == suit)
                            points += 14;
                        // If suit is dominant, then 0
                        else
                            points += 0;
                        break;
                }
            }
            // Declares output to user
            Console.WriteLine(points);
        }
    }
}