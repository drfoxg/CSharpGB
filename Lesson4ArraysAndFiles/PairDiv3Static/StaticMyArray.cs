using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PairDiv3Static
{
    static class StaticMyArray
    {
        private static int[] _a;
        public static int[] MyIntArray
        {
            get => _a;
        }

        static StaticMyArray() 
        {
            _a = new int[0];
        }

        // Создание массива и заполнение его случайными числами от min до max
        public static void InitMyArray(int n, int min, int max)
        {
            _a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                _a[i] = rnd.Next(min, max);
            }
        }

        public static int PairsCounter(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i] % 3 == 0 & arr[i + 1] % 3 != 0) |
                    (arr[i] % 3 != 0 & arr[i + 1] % 3 == 0))
                {
                    count++;
                }
            }

            return count;
        }

        public static string ToString()
        {
            string s = "";
            foreach (int v in _a)
                s = s + v + " ";
            return s;
        }

        public static int[] ReadFromFile(int size, string filename)
        {
            int[] arr = new int[size];
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(filename);
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = Convert.ToInt32(sr.ReadLine());
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                arr = null;
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                arr = null;
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }                
            }

            return arr;
        }
    }
}
