using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLibrary;

namespace OddSum
{
    class Program
    {
        /*
         * 3. С клавиатуры вводятся числа, пока не будет введен 0.
         * Подсчитать сумму всех нечетных положительных чисел.
         * 
         */
        static void Main(string[] args)
        {
            Console.WriteLine($"Cумма всех нечетных положительных чисел: {OddSum()}");

            Library.Pause("Нажмите любую кнопку");
        }

        static int OddSum()
        {
            int sum = 0;

            Console.WriteLine("Считаем сумму всех нечетных положительных чисел");
            Library.Print("Введите числа, 0 - конец ввода чисел:");
            
            int number = 0;
            string input = Console.ReadLine();

            if (input.Length != 0)
            {
                number = Convert.ToInt32(input);
            }
            else
            {
                Console.WriteLine("Вы ничего не ввели. Конец работы программы.");
            }

            while (number != 0)
            {
                if (number > 0 && ((number % 2) != 0 && number > 0))
                {
                    sum += number;
                }

                input = Console.ReadLine();
                if (input.Length != 0) {
                    number = Convert.ToInt32(input);
                }
            }

            return sum;

        }
    }
}
