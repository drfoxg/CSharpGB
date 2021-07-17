using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLibrary;

namespace FractionalNumber
{
    class Program
    {
        /*
         * 3. * Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
         * Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу,
         * демонстрирующую все разработанные элементы класса.
         * * Добавить свойства типа int для доступа к числителю и знаменателю;
         * * Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
         * ** Добавить проверку, чтобы знаменатель не равнялся 0.
         * Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
         * *** Добавить упрощение дробей.
         */

        static void Main(string[] args)
        {
            // 1/6
            Fractional a = new Fractional(1, 6);
            // 2/3
            Fractional b = new Fractional(2, 3);

            Fractional c = a.Sum(b);
            Library.PrintGreenLine("Sum: " + c.ToString() + $" Сокращенная дробь: {c.Reduction().ToString()}" + $" Десятичная дробь: {c.DecimalFraction, 0:f2}");

            c = a.Sub(b);
            Library.PrintGreenLine("\nSub: " + c.ToString() + $" Сокращенная дробь: {c.Reduction().ToString()}" + $" Десятичная дробь: {c.DecimalFraction, 0:f2}");

            c = a.Multi(b);
            Library.PrintGreenLine("\nMulti: " + c.ToString() + $" Сокращенная дробь: {c.Reduction().ToString()}" +  $" Десятичная дробь: {c.DecimalFraction, 0:f2}");

            c = a.Div(b);
            Library.PrintGreenLine("\nDiv: " + c.ToString() + $" Сокращенная дробь: {c.Reduction().ToString()}" + $" Десятичная дробь: {c.DecimalFraction, 0:f2}");

            Library.Pause("\nНажмите любую кнопку");
        }
    }
}
