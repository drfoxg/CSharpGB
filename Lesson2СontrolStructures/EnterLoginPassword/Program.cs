using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLibrary;

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
         */
        static void Main(string[] args)
        {
            string correct_login= "root";
            string correct_password = "GeekBrains";
            string login;
            string password;
            int i = 1;
            const int max_try = 3;

            do {
                Library.Print("Введите логин:");
                login = Console.ReadLine().Trim();
                Library.Print("Введите пароль:");
                password = Console.ReadLine();

                if (correct_login != login && correct_password != password)
                {
                    Console.WriteLine("Ошибка. Попытка {0} из {1}", i, max_try);
                    i++;
                } else {
                    Library.Print("Успешно");
                    break;
                }
            } while (i <= max_try);

            
            Library.Pause("Нажмите любую кнопку");
        }
    }
}
