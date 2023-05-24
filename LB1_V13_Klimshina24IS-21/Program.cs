using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1_V13_Klimshina24IS_21
{
    internal class Program
    {
        //Проверить соотношение log(a,b)=ln(a)/ln(b)
        static void Main(string[] args)
        {
            // Запросить у пользователя значение a, b
            Console.Write("Введите значение a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение b: ");
            double b = double.Parse(Console.ReadLine());

            // Вычислить соотношение
            double log = (Math.Log(a)) / (Math.Log(b));
            

            // Вывести результаты на экран
            Console.WriteLine("log({0}, {1}) = {2}", a, b, log);
        }
    }
}
