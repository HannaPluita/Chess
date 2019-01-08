using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public enum BoardColor
    {
        NoColor = -1,
        Black = 0,
        DarkBlue = 1,
        DarkGreen = 2,
        DarkCyan = 3,
        DarkRed = 4,
        DarkMagenta = 5,
        DarkYellow = 6,
        Gray = 7,
        DarkGray = 8,
        Blue = 9,
        Green = 10,
        Cyan = 11,
        Red = 12,
        Magenta = 13,
        Yellow = 14,
        White = 15
    }

    public class ConsoleView
    {
        public ConsoleView(IVisual visualBoard)
        {
            _iVisual = visualBoard;

            _symbols.Add(Figures.Empty, ' ');
            _symbols.Add(Figures.King, 'K');
            _symbols.Add(Figures.Queen, 'Q');
            _symbols.Add(Figures.Rook, 'R');    //Ладья
            _symbols.Add(Figures.Knight, 'k');  //Конь
            _symbols.Add(Figures.Bishop, 'B');  //Офицер
            _symbols.Add(Figures.Pawn, 'P');
        }

        public void PrintBoard()              //Print board to console
        {
            Console.BackgroundColor = ToConsoleColor(VisualBoard.BACKDROP_COLOR);
            Console.ForegroundColor = ToConsoleColor(VisualBoard.FRAME_COLOR);

            //i - horizontal, j - vertical

            for (int j = 0; j < _iVisual.HorizontalSize + 2; j++)
            {
               Console.Write('-');
            }
               Console.WriteLine();

            for (int i = 0; i < _iVisual.HorizontalSize; i++)
            {
                Console.Write('|');
                for (int j = 0; j < _iVisual.VerticalSize; j++)
                {
                    ConsoleColor oldForeColor = Console.ForegroundColor;
                    ConsoleColor oldBackColor = Console.BackgroundColor;

                    Console.BackgroundColor = ToConsoleColor(_iVisual[i, j].CellColor);

                    if (_iVisual[i, j].Figure != Figures.Empty)
                    {
                        Console.ForegroundColor = ToConsoleColor(_iVisual[i, j].FigureColor);
                    }
                    else
                    {
                        Console.ForegroundColor = ToConsoleColor(_iVisual[i, j].CellColor);
                        Console.BackgroundColor = Console.ForegroundColor;
                    }

                    Console.Write(_symbols[_iVisual[i, j].Figure]);

                    Console.ForegroundColor = oldForeColor;
                    Console.BackgroundColor = oldBackColor;
                }
                Console.WriteLine('|');
            }

            for (int j = 0; j < _iVisual.HorizontalSize + 2; j++)
            {
                Console.Write('-');
            }
            Console.WriteLine();
        }

        public static ConsoleColor ToConsoleColor(BoardColor boardColor)
        {
            return (ConsoleColor)boardColor;
        }

        protected IVisual _iVisual;

        protected readonly Dictionary<Figures, char> _symbols = new Dictionary<Figures, char>();
        
    }
}
