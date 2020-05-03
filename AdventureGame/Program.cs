/*
 * The Cursed Temple of Kumala
 * By: Matthew Oliver, April 2020
 * 
 * This work is intednded for use by Dakota State University
 * for the purpose of CSC-260-DT1 semester project
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    public static class Game
    {
        //Character Name
        static string CharacterName = "Matthew Oliver";

        //Print out game title and overview
        public static void StartGame()
        {
            GameTitle();
            Console.WriteLine("The Cursed Temple of Kumala\n\n");
            Continue();
            Console.WriteLine("Welcome to The Cursed Temple of Kumala!\n");
            Console.WriteLine("This is a Fantasy Pick Your own adventure game, and my first attempt at making a game! I hope you enjoy it!\n\n");
            Continue();
            NameCharacter();
            Continue();
            Choice();
            EndGame();
        }
        static void GameTitle()
        {
            string Title = @"The Cursed Temple of Kumala";
            Console.Title = Title;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Title);
            Console.ResetColor();
            Console.WriteLine("Press enter to start");
            Console.ReadKey();
            Console.Clear();
        }

        //Ask player for a name, and save it
        static void NameCharacter()
        {
            Console.WriteLine("What would you like to name your character?\n");
            Console.Write("Character Name: ");
            CharacterName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("It appears that your character name is " + CharacterName + ". Good luck and I hope you have fun!\n\n");
        }

        static void Continue()
        {
            Console.Write("Press Enter to Continue...");
            Console.ReadKey();
            Console.Clear();
        }

        static void Choice()
        {
            string input = "";
            Console.WriteLine(CharacterName + ", will you choose option A or B?");
            input = Console.ReadLine();
            input = input.ToLower();

            if(input == "a")
            {
                Console.WriteLine("You've chosen option A!");
            }

            else if(input == "b")
            {
                Console.WriteLine("You've chosen option B!");
            }

        }

        public static void EndGame()
        {
            //End of game text
            Console.WriteLine("You have survived the curse and became one of the most renown explorers in the world, Congradulations!");

            Console.WriteLine("Press enter to exit.");
        }
    }
    class item
    { }
    class Program
    {
        static void Main()
        {
            Game.StartGame();
            Console.ReadKey();
        }
    }
}
