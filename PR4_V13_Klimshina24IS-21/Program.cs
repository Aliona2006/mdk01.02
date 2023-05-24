using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4_V13_Klimshina24IS_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] arr = new int[3, 3, 3] { { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } },
                                              { { 10, 11, 12 }, { 13, 14, 15 }, { 16, 17, 18 } },
                                              { { 19, 20, 21 }, { 22, 23, 24 }, { 25, 26, 27 } } }; // трехмерный массив

            int layer = 0; // текущий слой
            int maxLayer = arr.GetLength(0) - 1; // максимальный слой

            Console.WriteLine("Текущий слой: " + layer);
            PrintLayer(arr, layer); // выводим на экран текущий слой

            while (true) // бесконечный цикл для обработки нажатий клавиш
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true); // считываем нажатую клавишу

                if (keyInfo.Key == ConsoleKey.LeftArrow && layer > 0) // если нажата клавиша "влево" и текущий слой не является первым
                {
                    layer--; // переходим на предыдущий слой
                    Console.WriteLine("Текущий слой: " + layer);
                    PrintLayer(arr, layer); // выводим на экран новый слой
                }
                else if (keyInfo.Key == ConsoleKey.RightArrow && layer < maxLayer) // если нажата клавиша "вправо" и текущий слой не является последним
                {
                    layer++; // переходим на следующий слой
                    Console.WriteLine("Текущий слой: " + layer);
                    PrintLayer(arr, layer); // выводим на экран новый слой
                }
            }
        }

        static void PrintLayer(int[,,] arr, int layer) // метод для вывода на экран слоя трехмерного массива
        {
            Console.WriteLine("Слой " + layer + ":");
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                for (int j = 0; j < arr.GetLength(2); j++)
                {
                    Console.Write(arr[layer, i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}