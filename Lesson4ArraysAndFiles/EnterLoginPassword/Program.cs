using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLibrary;
using System.IO;

namespace EnterLoginPassword
{
    class Program
    {
        /*
         * 4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
         * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
         * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
         * программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
         * 
         * 4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
         * Создайте структуру Account, содержащую Login и Password.
         */

        struct Account
        {
            public string _correctLogin;
            public string _correctPassword;
            public string _login;
            public string _password;
        }

        public static string[] ReadFromFileStrings(int size, string filename)
        {
            string[] arr = new string[size];
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(filename);
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = sr.ReadLine();
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

        static void Main(string[] args)
        {
            Account account = new Account
            {
                _correctLogin = "root",
                _correctPassword = "GeekBrains"
            };

            int i = 1;


            string[] passwd = new string[2];
            passwd = ReadFromFileStrings(2, "passwd.dat");
            account._login = passwd[0];
            account._password = passwd[1];


            Console.WriteLine("Считываем данные из файла...");
            if (account._correctLogin == account._login && account._correctPassword == account._password)
            {
                Library.Print("Успешно");
            }
            else
            {
                Library.Print("Не успешно");
            }
            
            Library.Pause("Нажмите любую кнопку");
        }
    }
}
