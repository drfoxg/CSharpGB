using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace MyLibrary
{

    public class MyArray2D
    {
        private int[,] _a2;
        public int[,] MyIntArray2D
        {
            get => _a2;
        }

        private string _delimiter = "\t";

        public string Delimiter
        {
            get => _delimiter;
            set => _delimiter = value;
        }

        // Создание массива и заполнение его одним значением el
        public MyArray2D(int x, int y, int el)
        {
            _a2 = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {

                    _a2[i, j] = el;
                }
            }
        }
        
        // Создание массива и заполнение его случайными числами от min до max
        public MyArray2D(int x, int y, int min, int max)
        {
            _a2 = new int[x, y];
            Random rnd = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {

                    _a2[i, j] = rnd.Next(min, max);
                }
            }
        }

        public MyArray2D(int rows, string filename)
        {
            int[][] arr = new int[rows][];

            string line;
            string[] subs;
            string[] stringSeparators = new string[] { " " };
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(filename);
                for (int i = 0; i < rows; i++)
                {
                    line = sr.ReadLine();
                    subs = line.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
                    arr[i] = new int[subs.Length];

                    for (int j = 0; j < subs.Length; j++)
                    {
                        arr[i][j] = Convert.ToInt32(subs[j]);
                    }
                }

                _a2 = new int[rows, arr[0].Length];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < arr[0].Length; j++)
                    {

                        _a2[i, j] = arr[i][j];
                    }
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
        }


        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < _a2.GetLength(0); i++)
                {
                    for (int j = 0; j < _a2.GetLength(1); j++)
                    {
                        sum = sum + _a2[i, j];
                    }
                }
                return sum;
            }
        }

        public int SumOverLevel(int level)
        {
            int sum = 0;
            for (int i = 0; i < _a2.GetLength(0); i++)
            {
                for (int j = 0; j < _a2.GetLength(1); j++)
                {
                    if (_a2[i, j] > level)
                    {
                        sum = sum + _a2[i, j];
                    }
                }
            }

            return sum;
        }

        public int Max
        {
            get
            {
                int max = _a2[0, 0];
                // GetLength(0) - rows
                // GetLength(0) - colums
                for (int i = 0; i < _a2.GetLength(0); i++)
                {
                    for (int j = 0; j < _a2.GetLength(1); j++)
                    {
                        if (_a2[i, j] > max)
                        {
                            max = _a2[i, j];
                        }
                    }
                }

                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = _a2[0, 0];
                // GetLength(0) - rows
                // GetLength(0) - colums
                for (int i = 0; i < _a2.GetLength(0); i++)
                {
                    for (int j = 0; j < _a2.GetLength(1); j++)
                    {
                        if (_a2[i, j] < min)
                        {
                            min = _a2[i, j];
                        }
                    }
                }
    
                return min;
            }
        }

        public void MaxIndex(out string indexes)
        {
            string indexes_ = "";
            int max = _a2[0, 0];
            // GetLength(0) - rows
            // GetLength(0) - colums
            for (int i = 0; i < _a2.GetLength(0); i++)
            {
                for (int j = 0; j < _a2.GetLength(1); j++)
                {
                    if (_a2[i, j] > max)
                    {
                        max = _a2[i, j];
                    }
                }
            }

            //max = _a2[_a2.GetLength(0), _a2.GetLength(1)];

            for (int i = 0; i < _a2.GetLength(0); i++)
            {
                for (int j = 0; j < _a2.GetLength(1); j++)
                {
                    if (_a2[i, j] == max)
                    {
                        indexes_ = indexes_ + "[" + i + ", " + j + "]" + " ";
                    }
                }
            }

            indexes_ = indexes_.Trim();
            indexes = indexes_;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < _a2.GetLength(0); i++)
            {
                for (int j = 0; j < _a2.GetLength(1); j++)
                {
                    s.Append(_a2[i, j] + Delimiter);
                }
                s.Append("\n");
            }

            return s.ToString();
        }

        public void SaveToFile(string filename, string delimiter)
        {
            Delimiter = delimiter;
            StreamWriter sw = null;
            try
            {
                string data = this.ToString();

                // создать или перезаписать файл
                sw = new StreamWriter(filename, false);                
                sw.WriteLine(data);
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

            Delimiter = "\t";
        }
    }
}
