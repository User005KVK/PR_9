using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practicheskai_Rabota_9
{
    internal class zmei
    {
        public static ConsoleKey key;
        public static List<string> zmeika = new List<string>() { "O" };
        public static int eat_col;
        public static int eat_row;
        public static int rrow;
        public static int col;
        public static int len = 1;
        public static string Zmei = "O";
        public static void draw_Zmei()
        {
            col = 38;
            rrow = 15;
            bool Harry = true;
            do
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(col, rrow);
                Console.Write(" ");
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        do
                        {
                            Thread.Sleep(250);
                            --col;
                            exit_bord();
                            Console.SetCursorPosition(col, rrow);
                            eat_Zmei();
                            foreach (var item in zmeika)
                            {
                                Console.WriteLine(item);
                            }
                            Console.SetCursorPosition(col + len, rrow);
                            Console.WriteLine(" ");
                        } while (key != ConsoleKey.RightArrow && key != ConsoleKey.UpArrow && key != ConsoleKey.DownArrow);
                        break;
                    case ConsoleKey.UpArrow:
                        do
                        {
                            Thread.Sleep(250);
                            --rrow;
                            exit_bord();
                            eat_Zmei();
                            Console.SetCursorPosition(col, rrow);

                            foreach (var item in zmeika)
                            {
                                Console.WriteLine(item);
                            }
                            Console.SetCursorPosition(col, rrow + len);
                            Console.WriteLine(" ");
                        } while (key != ConsoleKey.RightArrow && key != ConsoleKey.LeftArrow && key != ConsoleKey.DownArrow);
                        break;
                    case ConsoleKey.DownArrow:
                        do
                        {
                            Thread.Sleep(250);
                            ++rrow;
                            exit_bord();
                            eat_Zmei();
                            Console.SetCursorPosition(col, rrow);
                            foreach (var item in zmeika)
                            {
                                Console.WriteLine(item);
                            }
                            Console.SetCursorPosition(col, rrow - len);
                            Console.WriteLine(" ");
                        } while (key != ConsoleKey.RightArrow && key != ConsoleKey.LeftArrow && key != ConsoleKey.UpArrow);
                        break;
                    case ConsoleKey.RightArrow:
                        do
                        {
                            Thread.Sleep(250);
                            ++col;
                            exit_bord();
                            eat_Zmei();
                            Console.SetCursorPosition(col, rrow);
                            foreach (var item in zmeika)
                            {
                                Console.WriteLine(item);
                            }
                            Console.SetCursorPosition(col - len, rrow);
                            Console.WriteLine(" ");
                        } while (key != ConsoleKey.UpArrow && key != ConsoleKey.LeftArrow && key != ConsoleKey.DownArrow);
                        break;
                }
            } while (Harry == true);

        }
        public static void eat()
        {
            Random rnd = new Random();
            eat_col = rnd.Next(1, (int)ekran.down);
            eat_row = rnd.Next(1, (int)ekran.right);
            Console.SetCursorPosition(eat_col, eat_row);
            Console.Write("@");
        }

        private static void eat_Zmei()
        {
            if (eat_col == col && eat_row == rrow)
            {
                len++;
                eat_col = 0;
                eat_row = 0;
                zmeika.Add("0");
                foreach (var item in zmeika)
                {
                    Console.WriteLine(item);
                    eat();
                }
            }
        }

        private static void exit_bord()
        {
            if (col == 0 || col == (int)ekran.right)
            {
                Console.Clear();
                Environment.Exit(0);
            }
            if (rrow == 0 || rrow == (int)ekran.down)
            {
                Console.Clear();
                Environment.Exit(0);
            }
        }
    }
}