using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2_V13_Klimshina24IS_21
{
    internal class Program
    {
        //Даны две прямые. Определить,перпендикулярны ли они.


        static void Main(string[] args)
        {
            Console.Write("Введите коэффициенты первой прямой: ");
            double k1 = Convert.ToDouble(Console.ReadLine());
            double b1= Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите коэффициенты второй прямой: ");
            double k2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());

            if (k1 * k2 == -1.0)
            {
                Console.WriteLine("Прямые перпендикулярны.");
            }
            else
            {
                Console.WriteLine("Прямые не перпендикулярны.");
            }

        }
    }
}
