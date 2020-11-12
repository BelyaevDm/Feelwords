using Microsoft.VisualBasic;
using System;

namespace Feelword
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("      Feelwords");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            int num = 1;
            bool aaa = true;
            do
            {
                if (num == 1 || num > 4)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Новая игра");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Продолжить");
                    Console.WriteLine("Рекорды");
                    Console.WriteLine("Выход");
                    num = 1;
                }
                else if (num == 2)
                {
                    Console.WriteLine("Новая игра");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Продолжить");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Рекорды");
                    Console.WriteLine("Выход");
                }
                else if (num == 3)
                {
                    Console.WriteLine("Новая игра");
                    Console.WriteLine("Продолжить");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Рекорды");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Выход");
                }
                else if (num == 4 || num < 1)
                {
                    Console.WriteLine("Новая игра");
                    Console.WriteLine("Продолжить");
                    Console.WriteLine("Рекорды");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Выход");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    num = 4;
                }
                System.ConsoleKeyInfo button = Console.ReadKey();
                if (button.Key == ConsoleKey.S || button.Key == ConsoleKey.DownArrow)
                {
                    num++;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("      Feelwords");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                else if (button.Key == ConsoleKey.W || button.Key == ConsoleKey.UpArrow)
                {
                    num--;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("      Feelwords");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                else if (button.Key == ConsoleKey.Enter)
                {
                    aaa = false;
                }
            } while (aaa == true);
        }
    }
}
