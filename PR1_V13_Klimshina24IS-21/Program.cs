using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1_V13_Klimshina24IS_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double itog = Math.Round(((2.7 - 0.8) * 2 * (1.0 / 3.0)) / ((5.2 - 1.4) / Math.Pow(3.0 / 7.0, 1.0 / 5.0)) - Math.Pow(2.625, 1.0 / 5.0) + 8 * (9.0 / 25.0) - ((95 + 7.0 / 30.0 - 93 * (5.0 / 18.0)) * 2 * (1.0 / 4.0)) / Math.Sqrt(2) + Math.Pow(3.14, 1.0 / 6.0));
            Console.WriteLine("Результат вычислений: " + itog);
        }
    }
}
