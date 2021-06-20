using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLibrary;


namespace MinFromThree
{
    class Program
    {
        /*
         * 1. Написать метод, возвращающий минимальное из трёх чисел.
         * 
         */
        static void Main(string[] args)
        {
            const int size = 3;

            Library.Print($"Введите {size} {Library.getNumberEnding(size)}:");
            Console.WriteLine("Минимальное число {0:F2}", getMinFromNumbers(size));

            Library.Pause("Нажмите любую кнопку");
        }

        static double getMinFromNumbers(int size)
        {
            double number;
            double min;

            number = Convert.ToDouble(Console.ReadLine());
            min = number;

            for (int i = 0; i < size - 1; i++)
            {
                number = Convert.ToDouble(Console.ReadLine());
                if (number < min)
                {
                    min = number;
                }
            }

            return min;
        }
    }
}
