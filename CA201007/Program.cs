using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201007
{
    class Program
    {
        static Random rnd = new Random();
        static int[] tomb = new int[100];
        static void Main()
        {
            Feltolt();
            Kiir();
            for (int i = 0; i < 1000; i++)
            {
                RandomSzin();
                RandomHelyreIr();
            }
            Console.ReadKey();
        }
        static void Feltolt()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(10, 100);
            }
        }
        static void Kiir()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"{tomb[i]} ");
                if ((i + 1) % 10 == 0) Console.Write("\n");
            }
        }
        static void RandomHelyreIr()
        {
            Console.SetCursorPosition(
                rnd.Next(Console.WindowWidth),
                rnd.Next(Console.WindowHeight));
            Console.Write("*");
        }
        static void RandomSzin()
        {
            ConsoleColor[] szinek =
            {
                ConsoleColor.Green,
                ConsoleColor.Blue,
                ConsoleColor.Yellow,
                ConsoleColor.Red,
                ConsoleColor.Magenta,
            };
            Console.ForegroundColor = szinek[rnd.Next(szinek.Length)];
        }
            
    }
}
