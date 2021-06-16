using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using MyLibrary;

namespace ShowName
{
    class Program
    {
        /*
         * 5. а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
         * б) *Сделать задание, только вывод организовать в центре экрана.
         * в) **Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).
         * 
         */

        static void Main(string[] args)
        {
            Library.Print("Ваше имя:");
            string name = ReadLine();

            Library.Print("Ваша фамилия:");
            string surname = ReadLine();

            Library.Print("Ваш город:");
            string town = ReadLine();

            Console.Clear();

            Library.PrintCentre(name + " " + surname + " " + town);
            Library.PrintBottomLeft("Нажмите любую кнопку для завершения программы");

            Library.Pause();

        }
    }
}
