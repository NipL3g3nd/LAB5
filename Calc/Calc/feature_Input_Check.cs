using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

    internal class Program
    {
        static public double a;
        static public double b;
        static public string func;
        static public double result;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите пример по типу 'a + b'");
            while (true)
            {
                Console.Write("Введите a: ");
                double.TryParse(Console.ReadLine(), out a);

                Console.Write("Функция: ");
                func = Console.ReadLine();

                Console.Write("Введите b: ");
                double.TryParse(Console.ReadLine(), out b);

                if (func != "+" && func != "-" && func != "/" && func != "*") Console.WriteLine($"Ваша функция '{func}' не подходит", func);
                else {
                    if (func == "+") result = a + b;
                    if (func == "-") result = a - b;
                    if (func == "/") result = a / b;
                    if (func == "*") result = a * b;
                    Console.WriteLine($"Результат: {a} {func} {b} = {result}\n", a, func, b);
                }
            }
        }
    }
}