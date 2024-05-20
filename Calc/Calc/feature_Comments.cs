using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

    internal class Program
    {
        static public double a; //Первая переменная в примере
        static public double b; //Вторая переменная в примере
        static public string func; //Функция (оператор) в примере
        static public double result; //Итоговый результат вычислений

        static void Main(string[] args)
        {
            Console.WriteLine("Введите пример по типу 'a + b'");
            while (true)
            {
                Console.Write("Введите a: ");
                a = Double.Parse(Console.ReadLine());

                Console.Write("Функция: ");
                func = Console.ReadLine();

                Console.Write("Введите b: ");
                b = Double.Parse(Console.ReadLine());

                if (func != "+" && func != "-" && func != "/" && func != "*") Console.WriteLine($"Ваша функция '{func}' не подходит", func);
                else {
                    if (func == "+") result = a + b; //Сумма
                    if (func == "-") result = a - b; //Разность
                    if (func == "/") result = a / b; //Деление
                    if (func == "*") result = a * b; //Умножение
                    Console.WriteLine($"Результат: {a} {func} {b} = {result}\n", a, func, b); //Вывод примера и результата
                }
            }
        }
    }
}