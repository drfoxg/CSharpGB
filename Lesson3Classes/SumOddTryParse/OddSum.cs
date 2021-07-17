using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumOddTryParse
{
    class OddSum
    {
        public int Do() 
        {
            int sum = 0;
            int number;

            number = CheckInput();

            while (number != 0)
            {
                if (number > 0 && ((number % 2) != 0 && number > 0))
                {
                    sum += number;
                }

                number = CheckInput();
            }

            return sum;
        }

        private int CheckInput()
        {
            int number = 0;
            string input;
            bool isSuccess = true;

            do
            {
                input = Console.ReadLine();
                if (input.Length != 0)
                {
                    isSuccess = Int32.TryParse(input, out number);
                }
                else
                {
                    isSuccess = false;
                }

                if (!isSuccess)
                {
                    Console.WriteLine("Введите целое число, 0 - конец ввода чисел");
                }
            } while (!isSuccess);

            return number;
        }
    }
}
