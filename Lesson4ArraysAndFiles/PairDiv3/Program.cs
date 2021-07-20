using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLibrary;

namespace PairDiv3
{
    class Program
    {
        /* 1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые
         * значения от –10 000 до 10 000 включительно. Заполнить случайными числами.
         * Написать программу, позволяющую найти и вывести количество пар элементов массива,
         * в которых только одно число делится на 3.
         * В данной задаче под парой подразумевается два подряд идущих элемента массива.
         * Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
         */
        static void Main(string[] args)
        {
            
            MyArray mArr = new MyArray(20, -10000, 10000);
            int[] a = mArr.MyIntArray;

            Console.WriteLine("Дан целочисленный массив из 20 элементов.");
            Library.PrintGreenLine(mArr.ToString());

            int count = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if ((a[i] % 3 == 0 & a[i + 1] % 3 != 0) |
                    (a[i] % 3 != 0 & a[i + 1] % 3 == 0))
                {
                    count++;
                }
            }

            Console.WriteLine("Число пар: " + count);
            
            Library.Pause("Нажмит любую кнопку");

        }
    }
}
