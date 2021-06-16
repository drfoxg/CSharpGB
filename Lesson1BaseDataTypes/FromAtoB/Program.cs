using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLibrary;

using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("FromAtoBTest")]

namespace FromAtoB
{
    class Program
    {
        /*
         * 
         * 3. а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и
         * x2, y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат,
         * используя спецификатор формата .2f (с двумя знаками после запятой);
         * б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
         * 
         */
        static void Main(string[] args)
        {
            double x1 = 0;
            double x2 = 0;
            double y1 = 0;
            double y2 = 0;

            Library.Print("Введите координаты точки А, x и y с новой строки:");
            x1 = Convert.ToDouble(ReadLine());
            y1 = Convert.ToDouble(ReadLine());

            Library.Print("Введите координаты точки Б, x и y с новой строки:");
            x2 = Convert.ToDouble(ReadLine());
            y2 = Convert.ToDouble(ReadLine());

            WriteLine($"Расстояние между А и Б {GetDistance(x1, y1, x2, y2):F2}");

            Library.Pause("Нажмите любую кнопку для завершения программы");

        }

        internal static double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
