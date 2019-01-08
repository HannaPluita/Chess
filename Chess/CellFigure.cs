using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public enum Figures
    { Empty, King, Queen, Rook, Bishop, Knight, Pawn }

    public class CellFigure: Cell
    {
        #region----Constructors-----
        public CellFigure()
            :this(new Position(), ChessColor.White, Figures.Pawn)  //By default - A1 White Pawn
        {
        }

        public CellFigure(Position position, ChessColor figureColor, Figures figure)
            :base(position)
        {
            _figure = figure;
            _figureColor = figureColor;
        }

        public CellFigure(CellFigure cellFigure)
            :this(cellFigure._position, cellFigure._figureColor, cellFigure._figure)
        { }
        #endregion

        #region-----Properties-----
        public Figures Figure
        {
            get { return _figure; }
        }

        public ChessColor FigureColor
        {
            get { return _figureColor; }
        }
        #endregion

        protected Figures _figure;
        protected ChessColor _figureColor;
    }
}
