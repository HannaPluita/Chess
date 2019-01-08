using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public interface IVisual
    {
        int VerticalSize { get; }
        int HorizontalSize { get; }
        CellView this[int i, int j] { get; }
    }
   
    public struct CellView
    {
        public BoardColor CellColor { get; set; }   
        public BoardColor FigureColor { get; set; } 
        public Figures Figure { get; set; }

        public bool GetFigureColor(Cell cell)  //Pass to BoardVisual
        {
            bool ifColored = false;
            BoardColor figureBoardColor = BoardColor.NoColor;

            if(cell != null)
            {
                if (cell is CellFigure)
                {
                    if ((cell as CellFigure).FigureColor == ChessColor.White)
                    {
                        figureBoardColor = VisualBoard.WHITE_FIGURE_COLOR;
                    }
                    else
                    {
                        figureBoardColor = VisualBoard.BLACK_FIGURE_COLOR;
                    }
                    ifColored = true;
                }
                else
                {
                    FigureColor = BoardColor.NoColor;
                }
            }

            FigureColor = figureBoardColor;
            return ifColored;
        }

        public bool GetCellColor(Cell cell)
        {
            bool ifColored = false;
            BoardColor cellBoardColor = BoardColor.NoColor;

            if (cell != null)
            {
                if (cell.CellColor == ChessColor.White)
                {
                    cellBoardColor = VisualBoard.WHITE_CELL_COLOR;
                }
                else
                {
                    cellBoardColor = VisualBoard.BLACK_CELL_COLOR;
                }
                ifColored = true;
            }

            CellColor = cellBoardColor;
            return ifColored;
        }

        public bool GetFigure(Cell cell)
        {
            bool ifAssigned = false;
            Figures figure = Figures.Empty;

            if(cell != null && (cell is CellFigure))
            {
                figure = (cell as CellFigure).Figure;
                ifAssigned = true;
            }

            Figure = figure;

            return ifAssigned;
        }
    }

    public abstract class VisualBoard : IVisual
    {
        #region--------Constants------------
        public const BoardColor WHITE_CELL_COLOR = BoardColor.White;
        public const BoardColor BLACK_CELL_COLOR = BoardColor.Black;
        public const BoardColor WHITE_FIGURE_COLOR = BoardColor.Yellow;
        public const BoardColor BLACK_FIGURE_COLOR = BoardColor.DarkBlue;

        public const BoardColor BACKDROP_COLOR = BoardColor.DarkGray;
        public const BoardColor FRAME_COLOR = BoardColor.White;
        #endregion

        public int VerticalSize
        {
            get
            {
                return _cells.GetLength(1);
            }
        }

        public int HorizontalSize
        {
            get
            {
                return _cells.GetLength(0);
            }
        }

        public CellView this[int i, int j]  //i - horizontal, j - vertical
        {
            get
            {
                CellView cellView = new CellView();
                cellView.GetCellColor(_cells[i, j]);
                cellView.GetFigure(_cells[i, j]);
                cellView.GetFigureColor(_cells[i, j]);

                return cellView;
            }
        }

    protected Cell[,] _cells;
    }
}

