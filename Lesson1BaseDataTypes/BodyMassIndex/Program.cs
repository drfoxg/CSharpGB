using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using MyLibrary;

namespace BodyMassIndex
{
    class Program
    {
        /*
         *
         * 2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле
         * I=m/(h*h); где m — масса тела в килограммах, h — рост в сантиметрах.
         *
         */
        static void Main(string[] args)
        {
            int height = 0;
            double height_m = 0;
            int weight = 0;
            double body_index = 0;

            Console.OutputEncoding = Encoding.UTF8;

            WriteLine("Программа расчета индекса массы тела (ИМТ) I = m/(h * h)");
            
            WriteLine("Укажите вашу массу в килограммах без дробной части:");
            weight = Convert.ToInt32(ReadLine());

            WriteLine("Укажите вашу ваш рост в сантиметрах:");
            height = Convert.ToInt32(ReadLine());

            height_m = height / 100.0;
            body_index = weight / (height_m * height_m);

            WriteLine($"Ваш индекс массы тела:\n{body_index, 0:N1}\n");

            PrintInfo();

            Library.Pause();
        }

        internal static void PrintInfo()
        {

            ConsoleColor def_backgroundcolor = Console.BackgroundColor;
            ConsoleColor def_foregroundcolor = Console.ForegroundColor;

            const int FieldWidthLeftAligned = -40;
            const int FieldWidthRightAligned = 40;

            Console.ForegroundColor = ConsoleColor.Yellow;
            WriteLine($"|{"Индекс массы тела ИМТ", FieldWidthLeftAligned}|{"Классификация", FieldWidthRightAligned}|");

            Console.ForegroundColor = def_foregroundcolor;
            WriteLine($"|{"Меньше 16", FieldWidthLeftAligned}|{"Выраженный дефицит массы тела", FieldWidthRightAligned}|");
            WriteLine($"|{"16 – 18,5", FieldWidthLeftAligned}|{"Недостаточная масса тела", FieldWidthRightAligned}|");
            Console.ForegroundColor = ConsoleColor.Green;
            WriteLine($"|{"18,5 – 25", FieldWidthLeftAligned}|{"Нормальная масса тела", FieldWidthRightAligned}|");
            Console.ForegroundColor = def_foregroundcolor;
            WriteLine($"|{"25 – 30", FieldWidthLeftAligned}|{"Избыточная масса тела (предожирение)", FieldWidthRightAligned}|");
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine($"|{"30 – 35", FieldWidthLeftAligned}|{"Ожирение 1-ой степени", FieldWidthRightAligned}|");
            WriteLine($"|{"35 – 40", FieldWidthLeftAligned}|{"Ожирение 2-ой степени", FieldWidthRightAligned}|");
            WriteLine($"|{"Больше 40", FieldWidthLeftAligned}|{"Ожирение 3-ой степени", FieldWidthRightAligned}|");
            Console.ForegroundColor = def_foregroundcolor;

        }
    }
}

