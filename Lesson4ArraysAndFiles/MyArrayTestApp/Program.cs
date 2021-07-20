using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLibrary;

namespace MyArrayTestApp
{
    class Program
    {
        
        /* 3. а) Дописать класс для работы с одномерным массивом. Реализовать конструктор,
         * создающий массив определенного размера и заполняющий массив числами
         * от начального значения с заданным шагом.
         * Создать свойство Sum, которое возвращает сумму элементов массива,
         * метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива
         * (старый массив, остается без изменений),
         * метод Multi, умножающий каждый элемент массива на определённое число,
         * свойство MaxCount, возвращающее количество максимальных элементов.
         * б) ** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
         * е) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Класс для работы с одномерным массивом целых чисел.");

            MyArray mArr = new MyArray(2, -100, 100);
            //MyArray mArr = new MyArray(10, 500);
            Console.WriteLine(mArr);

            Console.WriteLine("Min: " + mArr.Min);
            Console.WriteLine("Max: " + mArr.Max);
            Console.WriteLine("Sum: " + mArr.Sum);
            Console.WriteLine("Invers: " + mArr.ToString(mArr.Invers()));
            Console.WriteLine("MaxCount: " + mArr.MaxCount);
            Console.WriteLine("Multi x2: " + mArr.ToString(mArr.Multi(2)));

            Library.Pause("Нажмит любую кнопку");
        }
    }
}
