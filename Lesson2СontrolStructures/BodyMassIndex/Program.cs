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
         * 5. а) Написать программу, которая запрашивает массу и рост человека,
         * вычисляет его индекс массы и сообщает, нужно ли человеку похудеть,
         * набрать вес или всё в норме.
         * б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
         * 
         */
        enum StatusOfWeight { Low, Normal, High };
            
        static void Main(string[] args)
        {
            int height = 0;
            decimal height_m = 0;
            int weight = 0;
            decimal body_index = 0;

            Console.OutputEncoding = Encoding.UTF8;

            WriteLine("Программа расчета индекса массы тела (ИМТ) I = m/(h * h)");
            
            WriteLine("Укажите вашу массу в килограммах без дробной части:");
            weight = Convert.ToInt32(ReadLine());

            WriteLine("Укажите вашу ваш рост в сантиметрах:");
            height = Convert.ToInt32(ReadLine());

            height_m = (decimal)(height / 100.0);
            body_index = weight / (height_m * height_m);

            WriteLine($"Ваш индекс массы тела:\n{body_index, 0:N1}\n");
            StatusOfWeight sow = CheckBodyIndex(body_index);
            WriteLine(doAdvise(sow, weight, height_m) + "\n");

            PrintInfo();

            Library.Pause();
        }

        private static string doAdvise(StatusOfWeight sow, int weight, decimal height_m)
        {
            string advise;
            decimal correct_weight = 0;
            const decimal correct_index = 25;

            correct_weight = correct_index * (height_m * height_m);
            switch (sow)
            {
                case StatusOfWeight.Low:                    
                    advise = "Рекомендация по вашему весу: набрать " + (correct_weight - weight) + " кг.";
                    break;
                case StatusOfWeight.Normal:
                    advise = "Рекомендация по вашему весу: вес в норме.";
                    break;
                case StatusOfWeight.High:
                    advise = "Рекомендация по вашему весу: сбросить " + (weight - correct_weight) + " кг.";
                    break;
                default:
                    advise = "Рекомендация по вашему весу: \"Ошибка во входных данных\"";
                    break;
            }

            return advise;
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

        static StatusOfWeight CheckBodyIndex(decimal BodyIndex)
        {
            if (BodyIndex < 18.5m)
            {
                return StatusOfWeight.Low;
            }

            if (BodyIndex >= 26.0m)
            {
                return StatusOfWeight.High;
            }
            else
            {
                return StatusOfWeight.Normal;
            }

        }

    }
}

