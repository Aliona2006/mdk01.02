using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_row
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя два числа x и a, а также длину ряда n
            Console.WriteLine("введите 2 числа: x, a");
            double x = Convert.ToDouble(Console.ReadLine());
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите длину ряда");
            double n = Convert.ToDouble(Console.ReadLine());

            // Инициализируем переменную a
            double m = 0;

            // Выполняем цикл для вычисления значения переменной m
            for (int i = 1, d = 0; i <= n; i++, d+=d)
            {
                m += Math.Pow(x, i) + Math.Pow(a, d) / (Math.Sin(Math.Pow((a + x), i)));           
            }

            // Выводим значение переменной a с округлением до двух знаков после запятой
            Console.WriteLine("M :");
            Console.WriteLine(Math.Round(m, 2));
        }
    }
}
