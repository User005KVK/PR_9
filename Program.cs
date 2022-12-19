using System.Security.AccessControl;

namespace Practicheskai_Rabota_9
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Чтобы начать игру нажмите Enter!");
            ConsoleKey key = Console.ReadKey().Key;

            if (key == ConsoleKey.Enter)
            {
                draw_border();
                Thread thread = new Thread(zmei.draw_Zmei);
                thread.Start();
                Thread two_thread = new Thread(zmei.eat);
                two_thread.Start();
                tab_key();

            }
        }
        static void tab_key()
        {
            while (true)
            {
                zmei.key = Console.ReadKey().Key;
            }
        }
        static void draw_border()
        {
            char border = 'X';
            string row = new String(border, (int)ekran.right); 
            Console.SetCursorPosition(0, 0);
            Console.Write(row);
            Console.SetCursorPosition(0, (int)ekran.down - 2); 
            Console.Write(row);
            for (int i = 0; i < (int)ekran.down - 2; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(border.ToString());
                Console.SetCursorPosition((int)ekran.right - 1, i);
                Console.Write(border.ToString());
            }
        }
    }
}