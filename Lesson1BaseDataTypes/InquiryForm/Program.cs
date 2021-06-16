using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Globalization;
using MyLibrary;

namespace InquiryForm
{
    class Program
    {
        /*
         * 
         * 1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
         * В результате вся информация выводится в одну строчку:
         * а) используя склеивание;
         * б) используя форматированный вывод;
         * в) используя вывод со знаком $.
         * 
         */
        static void Main(string[] args)
        {
            string name;
            string surname;
            int age;
            int height;
            int weight;

            Console.OutputEncoding = Encoding.UTF8;

            WriteLine("Ваше имя?");
            name = ReadLine();

            WriteLine("Ваша фамилия?");
            surname = ReadLine();

            WriteLine("Ваша возраст?");
            age = Convert.ToInt32(ReadLine());

            WriteLine("Ваша рост?");
            height = Convert.ToInt32(ReadLine());

            WriteLine("Ваша вес?");
            weight = Convert.ToInt32(ReadLine());

            WriteLine("[склейка]Вы ввели:\n" + "Имя: " + name + " Фамилия: " + surname + " Возраст: " + age + " Рост: " + height + " Вес: " + weight);
            WriteLine("[форматирование]Вы ввели:\nИмя: {0} Фамилия: {1} Возраст: {2} Рост: {3} Вес: {4}", name, surname, age, height, weight);
            WriteLine($"[интерполяция строк]Вы ввели:\nИмя: {name} Фамилия: {surname} Возраст: {age} Рост: {height} Вес: {weight}");

            Library.Pause();
        }
    }
}
