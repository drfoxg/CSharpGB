using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using MyLibrary;

namespace RecursionLoop
{
    class Program
    {
        /*
         * 7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
         * б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
         * 
         */
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int sum = 0;

            WriteLine("Введите целое число A:");
            a = Convert.ToInt32(ReadLine());
            WriteLine("Введите целое число B:");
            b = Convert.ToInt32(ReadLine());

            if (a < b)
            {
                Write("Числа от A до B: ");
                sum = Loop(a, b) + b;
                Library.Print($"\nСумма чисел от A до B: {sum }");
            } else
            {
                WriteLine("Ошибка. A больше либо равно B!");
            }

            Library.Pause("\nНажмите любую кнопку");
        }
        static int Loop(int a, int b)
        {
            int sum = 0;

            Write($"{a} ");
            if (a < b)
            {   
                sum = Loop(a + 1, b);
                sum += a;
            }

            return sum;
        }    
    }
}
