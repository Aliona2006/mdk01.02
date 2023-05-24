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
            Console.WriteLine("введите число x");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите число x0 (начальное)");
            double x0 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите число xk (конечное)");
            double xk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите число xh (шаг)");
            double xh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите число a");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите число b");
            double b = Convert.ToInt32(Console.ReadLine());

            double m = 0;
            double e = 3.14;
            while (x0 <= xk)
            {
                x0 += xh;
                m = 2.48 + Math.Cos(Math.Sin(b)) / Math.Pow(e, a + b) + Math.Pow(x, 3);
            }
            Console.WriteLine("M:");
            Console.WriteLine(Math.Round(m, 2));
        }
    }
}
