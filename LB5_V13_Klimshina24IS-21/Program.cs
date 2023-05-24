using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB5_V13_Klimshina24IS_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] menuItems = { "1.МЧС (пожарная часть)", "2.Полиция", "3.Скорая медицинская помощь", "4.Аварийная газовая служба" };
            int currentItem = 0;
            bool exitMenu = false;

            Console.WriteLine("Выберите специальную службу из списка:");
            PrintMenuItem(menuItems, currentItem);

            while (!exitMenu)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow && currentItem > 0)
                {
                    currentItem--;
                    Console.Clear();
                    Console.WriteLine("Выберите специальную службу из списка:");
                    PrintMenuItem(menuItems, currentItem);
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow && currentItem < menuItems.Length - 1)
                {
                    currentItem++;
                    Console.Clear();
                    Console.WriteLine("Выберите специальную службу из списка:");
                    PrintMenuItem(menuItems, currentItem);
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine("Вы выбрали: " + menuItems[currentItem]);
                    exitMenu = true;
                }
                else if (keyInfo.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.WriteLine("Вы точно хотите выйти из меню? (y/n)");
                    keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Y)
                    {
                        exitMenu = true;
                    }
                    else if (keyInfo.Key == ConsoleKey.N)
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите специальную службу из списка:");
                        PrintMenuItem(menuItems, currentItem);
                    }
                }
            }
        }

        static void PrintMenuItem(string[] menuItems, int currentItem)
        {
            for (int i = 0; i < menuItems.Length; i++)
            {
                if (i == currentItem)
                {
                    Console.Write("> ");
                }
                else
                {
                    Console.Write("  ");
                }
                Console.WriteLine(menuItems[i]);
            }
        }
    }
}
