using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLibrary;

namespace SumOddTryParse
{
    class Program
    {
        /*
         * 2. а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
         * Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
         */
        static void Main(string[] args)
        {
            OddSum oddSum = new OddSum();

            Library.Print("Введите число, 0 - конец ввода чисел:");
            Console.WriteLine($"Cумма всех нечетных положительных чисел: {oddSum.Do()}");

            Library.Pause("Нажмите любую кнопку");
        }
    }
}
