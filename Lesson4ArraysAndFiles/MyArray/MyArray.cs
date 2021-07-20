using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MyLibrary
{
    public class MyArray
    {
        private int[] _a;
        public int[] MyIntArray
        {
            get => _a;
        }

        // Создание массива и заполнение его одним значением el
        public MyArray(int n, int el)
        {
            _a = new int[n];
            for (int i = 0; i < n; i++)
                _a[i] = el;
        }
        // Создание массива и заполнение его случайными числами от min до max
        public MyArray(int n, int min, int max)
        {
            _a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                _a[i] = rnd.Next(min, max);
            }
        }

        // Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами
        // от начального значения с заданным шагом
        public MyArray(int n, int start, int step, int resrved = 0)
        {
            _a = new int[n];
            _a[0] = start;

            for (int i = 1; i < n; i++)
            {
                _a[i] = _a[i - 1] + step;
            }
        }

        public int Sum
        {            
            get
            {
                int sum = _a[0];
                for (int i = 1; i < _a.Length; i++)
                {
                    sum = sum + _a[i];
                }
                return sum;
            }
        }

        public int[] Invers()
        {
            int[] b = new int[_a.Length];

            for (int i = 0; i < b.Length; i++)
            {
                b[i] = -_a[i];
            }
            
            return b;
        }

        public int[] Multi(int multiplier)
        {
            int[] b = new int[_a.Length];

            for (int i = 0; i < _a.Length; i++)
            {
                b[i] = multiplier * _a[i];
            }

            return b;
        }

        public int Max
        {
            get
            {
                int max = _a[0];
                for (int i = 1; i < _a.Length; i++)
                {
                    if (_a[i] > max)
                    {
                        max = _a[i];
                    }
                }
                return max;
            }
        }

        public int MaxCount
        {
            get
            {
                int count = 0;
                Array.Sort(_a);                
                int max = _a.Last();

                for (int i = _a.Length - 1; i >= 0; i--)
                {
                    if (_a[i] == max)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
        public int Min
        {
            get
            {
                int min = _a[0];
                for (int i = 1; i < _a.Length; i++)
                { 
                    if (_a[i] < min) min = _a[i];
                }
                return min;
            }
        }
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < _a.Length; i++)
                {
                    if (_a[i] > 0) count++;
                }
                return count;
            }
        }
        public override string ToString()
        {
            string s = "";
            foreach (int v in _a)
            {
                s = s + v + " ";
            }
            return s;
        }

        public string ToString(int[] arr)
        {
            string s = "";
            foreach (int v in arr)
            {
                s = s + v + " ";
            }
            return s;
        }

        public void SaveToFile(int[] a, string filename)
        {
            StreamWriter sw = null;
            try
            {
                // создать или перезаписать файл
                sw = new StreamWriter(filename, false);
                foreach (int item in a)
                {
                    sw.WriteLine(item);
                }
                sw.Flush();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }

        public void SaveToFileSelf(string filename)
        {
            if (!File.Exists(filename))
            {
                StreamWriter sw = null;
                try
                {
                    // создать или перезаписать файл
                    sw = new StreamWriter(filename, false);
                    foreach (int item in _a)
                    {
                        sw.WriteLine(item);
                    }
                    sw.Flush();
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    if (sw != null)
                    {
                        sw.Close();
                    }
                }
            }
        }
    }
}
