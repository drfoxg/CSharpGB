using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FractionalNumber
{
    class Fractional
    {
        private int denominator;

        // числитель
        public int Numerator { get; set; }
        // знаменатель
        public int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                }
                else
                {
                    denominator = value;
                }
            }
        }

        public double DecimalFraction
        {
            get
            {
                return (double)Numerator / (double)Denominator;
            }
        }

        public Fractional()
        {
            Numerator = 0;
            Denominator = 1;
        }
        public Fractional(int n, int d)
        {
            Numerator = n;
            Denominator = d;
        }

        public Fractional Sum(Fractional b)
        {
            Fractional res = new Fractional();
            Fractional a = this;

            int nok = MathHelper.NOK(denominator, b.Denominator);

            res.Numerator   = nok / a.denominator * a.Numerator + nok / b.Denominator * b.Numerator;
            res.Denominator = nok;

            return res;
        }

        public Fractional Sub(Fractional b)
        {
            Fractional res = new Fractional();
            Fractional a = this;

            int nok = MathHelper.NOK(denominator, b.Denominator);

            res.Numerator   = nok / a.denominator * a.Numerator - nok / b.Denominator * b.Numerator;
            res.Denominator = nok;

            return res;
        }

        public Fractional Multi(Fractional b)
        {
            Fractional res = new Fractional();
            Fractional a = this;

            res.Numerator   = a.Numerator * b.Numerator;
            res.Denominator = a.Denominator * b.Denominator;

            return res;
        }

        public Fractional Div(Fractional b)
        {
            Fractional res = new Fractional();
            Fractional a = this;

            res.Numerator   = a.Numerator * b.Denominator;
            res.Denominator = a.Denominator * b.Numerator;

            return res;
        }

        public string ToString()
        {
            return Numerator + "/" + Denominator;
        }

        public Fractional Reduction()
        {
            Fractional res = new Fractional();

            int nod = MathHelper.NOD(Numerator, Denominator);

            res.Numerator = Numerator / nod;
            res.Denominator = Denominator / nod;

            return res;

        }

    }
}
