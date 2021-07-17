using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLibrary;

namespace Complex
{
    /*
     * 1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
     * б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
     * в) Добавить диалог с использованием switch демонстрирующий работу класса.
     */
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            ConsoleKeyInfo action;

            ComplexNum c1 = new ComplexNum();
            ComplexNum c2 = new ComplexNum();
            ComplexNum result;            

            do
            {                
                Console.WriteLine("Первое комплексное число");
                Console.WriteLine("Введите вещественную часть: ");
                c1.re = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите мнимую часть: ");
                c1.im = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Второе комплексное число");
                Console.WriteLine("Введите вещественную часть: ");
                c2.re = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите мнимую часть: ");
                c2.im = Convert.ToInt32(Console.ReadLine());                

                Console.WriteLine("Умножить или вычесть (1 или 2)?");

                action = Console.ReadKey();
                Console.WriteLine("");

                switch (ComplexNum.ToDo(action))
                {
                    case (ComplexNum.Action.multi):
                        result = c1.Multi(c2);
                        Console.WriteLine("Результат умножения:");
                        Console.WriteLine(result.ToString());
                        break;
                    case (ComplexNum.Action.sub):
                        result = c1.Sub(c2);
                        Console.WriteLine("Результат вычитания:");
                        Console.WriteLine(result.ToString());                        
                        break;
                    default:
                        Console.WriteLine("Укажите 1 или 2");
                        break;
                }

                Library.PrintGreen("\nEsc для выхода или любая клавиша для повтора\n");
                cki = Console.ReadKey(true);

            } while (cki.Key != ConsoleKey.Escape);

        }
    }
}
