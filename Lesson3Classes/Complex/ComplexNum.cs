using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Complex
{
    class ComplexNum
    {
        public double im;
        public double re;

        public enum Action { multi, sub, plus };

        public ComplexNum Plus(ComplexNum x)
        {
            ComplexNum y = new ComplexNum();
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        // Произведение двух комплексных чисел
        public ComplexNum Multi(ComplexNum x)
        {
            ComplexNum y = new ComplexNum();
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public string ToString()
        {
            return re + ((im < 0) ? ("") : "+" ) + im + "i";
        }

        // Вычитание двух  комплексных чисел
        public ComplexNum Sub(ComplexNum x)
        {
            ComplexNum y = new ComplexNum();
            y.re = re - x.re;
            y.im = im - x.im;

            return y;
        }

        public static Action ToDo(ConsoleKeyInfo cki)
        {
            Action action;

            switch (cki.Key)
            {
                case (ConsoleKey.D1):
                case (ConsoleKey.NumPad1):
                    action = Action.multi;
                    break;
                case (ConsoleKey.D2):
                case (ConsoleKey.NumPad2):
                    action = Action.sub;
                    break;

                default:
                    action = Action.multi;
                    break;
            }

            return action;
        }
    }
}
