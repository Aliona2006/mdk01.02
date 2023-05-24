using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите элементы массива через пробел: ");

            // Считываем строку, которую ввел пользователь
            string input = Console.ReadLine();

            // Разбиваем строку на подстроки по пробелам, парсим каждую подстроку в целое число и создаем массив из этих чисел
            int[] arr = input.Split(' ').Select(int.Parse).ToArray();

            // Считаем количество уникальных элементов в массиве и выводим результат на экран
            int distinctCount = arr.Distinct().Count();
            Console.WriteLine("Количество различных чисел в массиве: {distinctCount}");
            int count = 0;
            // подсчет количества нечетных элементов в заданном массиве
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    count++;
                }
            }
            int[] oddArr = new int[count]; // новый массив для нечетных элементов
            // заполнение нового массива нечетными элементами из заданного массива
            int j = 0; for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    oddArr[j] = arr[i];
                    j++;
                }
            }
            // переворот нового массива
            Array.Reverse(oddArr);

            // вывод нового массива на консоль
            Console.WriteLine("Новый массив нечётных чисел:");
            for (int i = 0; i < oddArr.Length; i++)
            {
                Console.Write(oddArr[i] + " ");
            }
        }
    }
}
