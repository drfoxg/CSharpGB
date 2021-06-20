using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using MyLibrary;

namespace GoogNumbers
{
    class Program
    {
        /*
         *  6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
         *  «Хорошим» называется число, которое делится на сумму своих цифр.
         *  Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
         * 
         */

        static void Main(string[] args)
        {
            const long  size = 1000000000;
            int count = 0;
            WriteLine("Подсчет количества «хороших» чисел в диапазоне от 1 до 1 000 000 000...");
                 
            DateTime start = DateTime.Now;

            /*
             * Дано натуральное число N
             * На каждое натуральное X [2 до N-1] надо взять остаток от деления N на X и сравнить с 0.
             * Если остаток 0, значит число удалось разделить, значит оно делится не только на 1 и N, но и на X.
             * 
             */
            for (int i = 1; i < size; i++)
            {
                if (i % Sum(i) == 0)
                {
                    count++;
                }
            }

            DateTime finish = DateTime.Now;
            WriteLine("Программа работала " + (finish - start));
            Library.Print($"Количество «хороших» чисел: {count}");

            Library.Pause("Нажмите любую кнопку");
        }

        static long Sum(long n)
        {
            long s = 0;
            while (n > 0)
            {
                s = s + n % 10; // добавляем к сумме последнюю цифру числа n
                n = n / 10; // отбрасываем от числа n последнюю цифру
            }

            return s;
        }
            

    }
}
