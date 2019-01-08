using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public enum ChessColor
    { NoColor ,Black, White }
    
    public class Cell
    {
        #region----Constructors-----
        public Cell()
            :this(new Position())
        {
        }

        public Cell(Position position)
        {
            _position = position;
            _cellColor = SetCellColor();
        }

        public Cell(int horizontal, int vertical)
            :this(new Position(horizontal, vertical))
        {}

        public Cell(Cell cell)
            :this(cell._position)
        {}
        #endregion

        #region-----Properties------

        public ChessColor CellColor
        {
            get { return _cellColor; }
        }

        public Position Position
        {
            get { return _position; }
        }
       
        #endregion

        #region-----Check/Set-------

        protected ChessColor SetCellColor()
        {
            ChessColor color = ChessColor.White;
            if (IfOdd((int)_position.Vertical) && IfOdd(_position.Horizontal) || IfEven((int)_position.Vertical) && IfEven(_position.Horizontal))
            {
                color = ChessColor.Black;
            }
            else
            {
                color = ChessColor.White;
            }
            return color;
        }

        public static bool IfEven(int x)
        {
            return x % 2 == 0;
        }

        public static bool IfOdd(int x)
        {
            return x % 2 == 1;
        }
        #endregion

        protected Position _position;
        protected ChessColor _cellColor;
    }
}
