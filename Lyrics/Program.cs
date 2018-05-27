/********************************************************************
 * Assignment from SDEV 240                                         *
 * Coded by: Harley Ehrman                                          *
 *                                                                  *
 * From book:                                                       *
 * Microsoft Visual C# 2015:                                        *
 * An Introduction to Object-Oriented Programming 6th Edition       *
 * by Joyce Farrell                                                 *
 *                                                                  *
 * Instructions (Page 44, Exercise 5):                              *
 * Write, compile, and test a program named Lyrics that displays    *
 * at least four lines of your favorite song.                       *
 ********************************************************************/

using System;

namespace Lyrics
{
    class Program
    {
        static void Main(string[] args)
        {
            //show song title and artist
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n" + "Sunny Came Home by Shawn Colvin" + "\n");
            Console.ResetColor();

            //repeatable strings
            string Line1 = "She says, \"Days go by,";
            string Line2 = "I don't know why.";
            string Line3 = "I'm hypnotized.";
            string Line4 = "I'm walking on a wire.";
            string Line5 = "I close my eyes and fly out of my mind into the fire.\"";
            string Line6 = "Sunny came home.";

            //display using WriteLine
            Console.WriteLine("Sunny came home to her favorite room. Sunny sat down in the kitchen.");
            Console.WriteLine("She opened a book and a box of tools. Sunny came home with a mission.");
            Console.WriteLine("\n" + Line1 + " " + Line3 + " " + Line4 + "\n" + Line5 + "\n");
            Console.WriteLine("Sunny came home with a list of names; she didn't believe in transcendence.");
            Console.WriteLine("\"It's time for a few small repairs,\" she said. Sunny came home with a vengeance.");
            Console.WriteLine("\n" + Line1 + " " + Line2 + " " + Line4 + "\n" + Line5 + "\n");
            Console.WriteLine("Get the kids and bring a sweater. Dry is good and wind is better.");
            Console.WriteLine("Count the years, you always knew it. Strike the match, go on and do it.");
            Console.WriteLine("\n" + "Oh, days go by, I'm hypnotized. I'm walking on a wire.");
            Console.WriteLine("I close my eyes and fly out of my mind into the fire.");
            Console.WriteLine("\n" + "Light the sky and hold on tight. The world is burning down.");
            Console.WriteLine("She's out there on her own and she's alright.");
            Console.WriteLine(Line6 + " " + Line6);

            //stops program from automatically closing after text displays.
            Console.ReadLine();
        }
    }
}