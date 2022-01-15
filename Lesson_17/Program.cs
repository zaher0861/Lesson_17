using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер счета строкой:");
            string numString = Convert.ToString(Console.ReadLine());
            Console.Write("Введите баланс:");
            double balance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ФИО:");
            string name = Convert.ToString(Console.ReadLine());
            Bank<string> bank1 = new Bank<string>(numString, balance, name);
            bank1.Number = numString;
            bank1.Balance = balance;
            bank1.Name = name;
            Console.WriteLine($"{bank1.Number} {bank1.Balance} {bank1.Name}");
            Console.Write("Введите номер счета числом:");
            int numInt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите баланс:");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ФИО:");
            name = Convert.ToString(Console.ReadLine());
            Bank<int> bank2 = new Bank<int>(numInt, balance, name);
            bank2.Number = numInt;
            bank2.Balance = balance;
            bank2.Name = name;
            Console.WriteLine($"{bank2.Number} {bank2.Balance} {bank2.Name}");
            Console.ReadKey();
        }
    }
    class Bank<T>
    {
        public T Number { get; set; }
        public double Balance { get; set; }
        public string Name { get; set; }
        public Bank(T number, double balance, string name)
        {
            Number = number;
            Balance = balance;
            Name = name;
        }
    }
}
