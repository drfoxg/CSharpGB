using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using MyLibrary;

namespace VarSwap
{
    class Program
    {
        /*
         * 4. Написать программу обмена значениями двух переменных:
         * а) с использованием третьей переменной;
         * б) *без использования третьей переменной.
        */

        static void Main(string[] args)
        {
            int a1 = 0;
            int b1 = 0;
            int c = 0;

            int a2 = 0;
            int b2 = 0;


            Library.Print("Введите два целых числа, каждое с новой строки:");
            a1 = a2 = Convert.ToInt32(ReadLine());
            b1 = b2 = Convert.ToInt32(ReadLine());
            WriteLine($"a: {a1}\t\tb: {b1}");

            // обмен через третью переменную
            c = b1;
            b1 = a1;
            a1 = c;
            WriteLine($"Обмен a: {a1}\tb: {b1}");

            // обмен без третьей переменной
            b2 += a2; 
            a2 = b2 - a2; //b2 == a2(old)
            b2 -= a2;     //a2 == b2(old)

            WriteLine($"Обмен a: {a2}\tb: {b2}");

            Library.Pause("Нажмите любую кнопку для завершения программы");
        }
    }
}
