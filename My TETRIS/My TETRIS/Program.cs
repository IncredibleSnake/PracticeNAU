using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_TETRIS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);


            Point p1 = new Point(2, 3, '*');
            p1.Draw();

            Square s1 = new Square(5, 6, '*');
            s1.Draw();

            Stick st1 = new Stick(10, 3, '$');
            st1.Draw();

            Console.ReadLine();
        }

    }
}
