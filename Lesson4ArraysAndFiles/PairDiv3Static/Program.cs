using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using MyLibrary;

namespace PairDiv3Static
{
    class Program
    {
        /* 2. Реализуйте задачу 1 в виде статического класса StaticClass;
         * а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
         * б) *Добавьте статический метод для считывания массива из текстового файла.
         * Метод должен возвращать массив целых чисел;
         * в) **Добавьте обработку ситуации отсутствия файла на диске.
         */
        static void Main(string[] args)
        {
            StaticMyArray.InitMyArray(20, -10000, 10000);
            int[] a = StaticMyArray.MyIntArray;
            int countA = StaticMyArray.PairsCounter(a);

            Console.WriteLine("Дан целочисленный массив из 20 элементов.");
            Library.PrintGreenLine(StaticMyArray.ToString());
            Console.WriteLine("Число пар: " + countA);

            // создаем новый массив, пишем в файл, читаем из файла, находи число пар
            MyArray mArr = new MyArray(20, -10000, 10000);
            mArr.SaveToFileSelf("data.txt");

            // проверка обработки исключения
            int[] b = StaticMyArray.ReadFromFile(20, "data1.txt");
            // правильный путь
            b = StaticMyArray.ReadFromFile(20, "data.txt");
            int countB = StaticMyArray.PairsCounter(b);
            
            Console.WriteLine("Дан целочисленный массив из 20 элементов в файле.");
            Library.PrintGreenLine(mArr.ToString(b));            
            Console.WriteLine("Число пар: " + countB);

            Library.Pause("Нажмит любую кнопку");

        }
    }
}
