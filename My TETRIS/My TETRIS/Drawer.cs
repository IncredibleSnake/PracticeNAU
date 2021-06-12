using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_TETRIS
{
    public static class Drawer
    {
        public const char DAFAULT_SYMBOL = '*';

        public static void DrawPoint(int x, int y, char c = DAFAULT_SYMBOL)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
            Console.SetCursorPosition(0, 0);
        }

        public static void HidePoint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
            Console.SetCursorPosition(0, 0);
        }
    }
}
