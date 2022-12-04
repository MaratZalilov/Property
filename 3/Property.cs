using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property
{
    internal class Property
    {
        private string _name;
        public string Name
        {
            get
            {
                var result = Password();
                if (result == true)
                {
                    return _name;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Неправильный пароль");
                    Console.WriteLine();
                    _name = "был введён неправильный пароль";
                    return _name;
                }
            }
            set
            {

                if (value.Length == 0)
                {
                    Console.WriteLine("Ошибка");
                    _name = "Нет имени";
                }
                else
                {
                    _name = value;
                }

            }
        }
        private string _surname;
        public string Surname
        {
            get
            {
                var result = Password();
                if (result == true)
                {
                    return _surname;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Неправильный пароль");
                    Console.WriteLine();
                    _name = "был введён неправильный пароль";
                    return _name;
                }
            }
            set
            {
                if (value.Length < 7)
                {
                    Console.WriteLine("Ошибка");
                    _surname = "Фамилия меньше 7 символов";
                    return;
                }
                _surname = value;
            }

        }
        public string DateOfBirth { get; set; }
        private bool Password()
        {
            string _password = "admin";
            for (int i = 2; i >= 0; i--)
            {
                Console.WriteLine("Введите пароль");
                string pass = Console.ReadLine();
                if (pass != _password)
                {
                    if (i > 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Неправильный пароль");
                        Console.WriteLine();

                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Попытки закончились");
                        Console.WriteLine();
                        return false;
                    }
                }
                else
                {

                    return true;
                }
            }
            return false;
        }
    }
}