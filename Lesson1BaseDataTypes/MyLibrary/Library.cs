using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibrary
{
    // моя библотека

    /*public enum ConsolePos
    {
        TopLeft, TopRight, Centre, BottomLeft, BottomRitgh
    }
    */

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

        /*public static void Print(ConsolePos pos, string message)
        { 
            
        }*/

        public static void PrintCentre(string message)
        {
            int centerX = (Console.WindowWidth / 2) - (message.Length / 2);
            int centerY = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(centerX, centerY);
            Console.Write(message);
        }

        public static void PrintTopLeft(string message)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(message);
        }

        public static void PrintTopRight(string message)
        {
            int topRightX = Console.WindowWidth - message.Length;
            Console.SetCursorPosition(topRightX, 0);
            Console.Write(message);
        }

        public static void PrintBottomLeft(string message)
        {
            int bottomY = Console.WindowHeight - 1;
            Console.SetCursorPosition(0, bottomY);
            Console.Write(message);
        }

        public static void PrintBottomRight(string message)
        {
            int bottomRightX = Console.WindowWidth - message.Length;
            int bottomY = Console.WindowHeight - 1;
            Console.SetCursorPosition(bottomRightX, bottomY);
            Console.Write(message);
        }
    }
}