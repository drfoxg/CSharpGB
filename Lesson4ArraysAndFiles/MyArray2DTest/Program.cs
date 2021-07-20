using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLibrary;
using System.IO;

namespace MyArray2DTest
{
    /* 5. *а) Реализовать библиотеку с классом для работы с двумерным массивом.
     * Реализовать конструктор, заполняющий массив случайными числами.
     * Создать методы, которые возвращают сумму всех элементов массива,
     * сумму всех элементов массива больше заданного,
     * свойство, возвращающее минимальный элемент массива,
     * свойство, возвращающее максимальный элемент массива,
     * метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
     * **б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
     * **в) Обработать возможные исключительные ситуации при работе с файлами.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Класс для работы с двумерным массивом целых чисел.");

            //MyArray2D mArr = new MyArray2D(2, 3, 100);
            MyArray2D mArr = new MyArray2D(2, 3, -5, 5);
            Console.WriteLine(mArr);

            Console.WriteLine("Min: " + mArr.Min);
            Console.WriteLine("Max: " + mArr.Max);

            string indexes = "";
            mArr.MaxIndex(out indexes);
            Console.WriteLine("MaxIndex: " + indexes);

            Console.WriteLine("Sum: " + mArr.Sum);
            int level = 2;
            Console.WriteLine("Sum больше заданного (level = {0}): {1} ", level, mArr.SumOverLevel(level));

            string filename = "data.txt";
            Console.WriteLine("Записываем массив в файл: {0}", filename);          
            mArr.SaveToFile(filename, " ");

            MyArray2D mArrFile = new MyArray2D(2, filename);
            Console.WriteLine("Конструктор из файла: ");
            Console.WriteLine(mArrFile);

            Library.Pause("Нажмит любую кнопку");
        }
    }
}

