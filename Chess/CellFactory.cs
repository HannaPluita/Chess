using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class CellFactory
    {
        public CellFactory(Board board)
        {
            _board = board;
        }

        public virtual Cell Create(Position pos)
        {
            //Vlidation check of pos parameter
            return new Cell(pos);
        }

        public virtual Cell Create(int i, int j)
        {
            return Create(new Position(i, j));
        }

        public Cell[,] CreateEmptyBoard()
        {
            int horizontalSize = _board.HorizontalSize;
            int verticalSize = _board.VerticalSize;
            return CreateEmptyBoard(horizontalSize, verticalSize);
        }

        public Cell[,] CreateEmptyBoard(int horizontalSize, int verticalSize)
        {
            Cell[,] cells = new Cell[horizontalSize, verticalSize];

            for(int i = 0; i < horizontalSize; ++i)
            {
                for(int j = 0; j < verticalSize; ++j)
                {
                    cells[i, j] = Create(new Position(i, j));
                }
            }

            return cells;
        }

        protected readonly Board _board; //Need only for verification checking. Can be applied with an interface.
    }
}
