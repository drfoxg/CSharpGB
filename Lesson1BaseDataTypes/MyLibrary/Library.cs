using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibrary
{
    // моя библотека
	
    public class Library
    {
        public static void Pause()
        {
            Console.ReadKey();
        }
        public static void Pause(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }

        public static void Print(string message)
        {
            ConsoleColor def_backgroundcolor = Console.BackgroundColor;
            ConsoleColor def_foregroundcolor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);

            Console.BackgroundColor = def_backgroundcolor;
            Console.ForegroundColor = def_foregroundcolor;
        }

        public static void Print(int x, int y, string message)
        {
            ConsoleColor def_backgroundcolor = Console.BackgroundColor;
            ConsoleColor def_foregroundcolor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(message);

            Console.BackgroundColor = def_backgroundcolor;
            Console.ForegroundColor = def_foregroundcolor;
        }
    }
}