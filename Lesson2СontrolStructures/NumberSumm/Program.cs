using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLibrary;

namespace NumberCount
{
    /*
     * 2. Написать метод подсчета количества цифр числа.
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            Library.Print("Введите число:");
            Console.WriteLine($"Количества цифр числа: {NumberCount(Convert.ToDecimal(Console.ReadLine()))}");            
            Library.Pause("Нажмите любую кнопку");
        }

        static int NumberCount(Decimal n)
        {
            Decimal origin = n;
            int i = 0;

            Decimal decimal_part = n % 1;
            if (decimal_part == 0)
            {
                while (n > 1)
                {
                    i++;
                    n = n / 10;
                }
            } else {
                n = origin;
                while (n > 1)
                {
                    i++;
                    n = n / 10;
                }

                Decimal dp = decimal_part;
                Decimal dp1 = dp % 1;
                while (dp1 != 0)
                {
                    i++;
                    dp = dp * 10;
                    dp1 = dp % 1;
                }
            }

            return i;
        }

    }
}
