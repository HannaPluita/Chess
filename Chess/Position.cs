using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public enum Vertical  //Identifier for the horizontal position
    {
        A = 0,
        B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z
    }

    public struct Position
    {
        public const int MAX_BOARD_LENGTH = 26;  // The maximum size of the board

        #region-----Constructors----

        public Position(int horizontal, int vertical)
        {
            _vertical = (Vertical)vertical;
            _horizontal = horizontal;
        }

        public Position(int horizontal, Vertical vertical)
        {
            _vertical = vertical;
            _horizontal = horizontal;
        }

        public Position(Position pos)
            :this(pos._horizontal, pos._vertical)
        {}
        #endregion

        #region------Properties-----

        public Vertical Vertical
        {
            get
            { return _vertical; }
        }

        public int VerticalInt
        {
            get
            { return (int)_vertical; }
        }

        public int Horizontal
        {
            get { return _horizontal; }
        }
        #endregion

        private Vertical _vertical;
        private int _horizontal;
    }
}
