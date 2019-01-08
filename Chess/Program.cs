using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            //Console.CursorVisible = false;

            ConsoleDraw.DrawFramePoint(0, 6, 8, 6);

            //Board b = new Board(8, 8);

            //CellFactory cf = new CellFactory(b);
            //Cell[,] cells = cf.CreateEmptyBoard();
            //b.AddRange(cells);
            //ConsoleView cw = new ConsoleView(b as IVisual);
            //cw.PrintBoard();

            Console.ReadKey();
        }
    }
}
