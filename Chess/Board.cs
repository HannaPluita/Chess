using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{

    public class Board: VisualBoard
    {
        public const int MAX_VERTICAL_SIZE = 26;
        public const int MAX_HORIZONTAL_SIZE = 30;

        public Board(int horizontal, int vertical)
        {
            //Check vertical and horizontal...

            _cells = new Cell[ horizontal, vertical];
        }

        public bool Add(Cell cell)
        {
            if(cell != null)
            {
                _cells[cell.Position.Horizontal, cell.Position.VerticalInt] = cell;
                return true;
            }
            return false;
        } 

        public bool AddRange(Cell[,] cells)
        {
            bool ifAdded = false;
            for(int i = 0; i < cells.GetLength(0); ++i)
            {
                for(int j = 0; j < cells.GetLength(1); ++j)
                {
                    _cells[i, j] = cells[i, j];
                }
            }
            return ifAdded;
        }
    }
}
