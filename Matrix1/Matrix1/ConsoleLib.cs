using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix1
{
    public class ConsoleLib
    {

        public static void GotoXY(int _x, int _y) => Console.SetCursorPosition(_x, _y);

        public static void WriteChar(int _x, int _y, char _symbol)
        {
            Console.SetCursorPosition(_x, _y);
            Console.Write(_symbol);
        }

        public static void WriteChars(int _x, int _y, char _symbol, int count)
        {
            Console.SetCursorPosition(_x, _y);
            for (int i = 0; i < count; i++)
            {
                Console.Write(_symbol);
            }
        }
        public static char CRand()
        {
            Random rand = new Random();
            char c = (char)rand.Next('A', 'Z');
            return c;
        }
        public static void SetColor(ConsoleColor ColorText, ConsoleColor ColorBack)
        {
            Console.ForegroundColor = ColorText;
            Console.BackgroundColor = ColorBack;
        }
    }
}
