using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace My_TETRIS
{
    static class Field
    {
        public static int _height = 20;
        public static int _width = 20;
        public static int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                Console.SetWindowSize(_width, Field.Height);
                Console.SetBufferSize(_width, Field.Height);
            }
        }
        public static int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                Console.SetWindowSize(Field.Width, _height);
                Console.SetBufferSize(Field.Width, _height);
            }
        }

        private static bool[][] _heap;
        
        static Field()
        {
            _heap = new bool[Height][];
            for(int i = 0; i < Height; i++)
            {
                _heap[i] = new bool[Width];
            }
        }

        internal static void TryDeleteLines()
        {
            for(int j = 0; j < Height; j++)
            {
                int counter = 0;
                for (int i = 0; i < Width; i++)
                {
                    if (_heap[j][i])
                    {
                        counter++;
                    }
                }
                if (counter >= Width - 1)
                {
                    DeleteLine(j);
                    Redraw();
                }


            }
        }

        private static void Redraw()
        {
            for(int j = 0; j < Height; j++)
            {
                for(int i = 0; i < Width; i++)
                {
                    if (_heap[j][i])
                        Drawer.DrawPoint(i,j);      
                    else
                        Drawer.HidePoint(i,j);      
                }
            }
        }

        private static void DeleteLine(int line)
        {
            for(int j = line; j >= 0; j--)
            {
                for(int i = 0; i < Width; i++)
                {
                    if (j == 0)
                    {
                        _heap[j][i] = false;
                    }
                    else
                    _heap[j][i] = _heap[j - 1][i];
                }
            }
        }

        public static bool CheckStrike(Point p)
        {
            return _heap[p.Y][p.X];
        }
        public static void AddFigure(Figure fig)
        {
            foreach(var p in fig.Points)
            {
                _heap[p.Y][p.X] = true;
            }
        }
    }
}
